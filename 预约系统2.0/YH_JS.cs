using chloe_control_namespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 预约系统2._0
{
    public partial class YH_JS : Form
    {
        public YH_JS()
        {
            InitializeComponent();
        }

        public static String Paymoney = "NO";
        public static String CHANGDI;
        public static String mid = "12:00";
        public static String aft = "14:00";
        public static String MMMM;

        private void button2_Click(object sender, EventArgs e)
        {
            YH yh1 = new YH();
            this.Hide();
            yh1.Show();
        }

        private void Test_JS_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet17.Booking”中。您可以根据需要移动或删除它。
            this.bookingTableAdapter.Fill(this.场馆预约系统DataSet17.Booking);
            Start kk = new Start();
            String KK = Start.CUser;
            List<Booking> user_list = new List<Booking>();
            listView1.Items.Clear();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            user_list = chloe_obj.person_search(KK);
            for (int i = 0; i < user_list.Count; i++)
            {
                ListViewItem user_item = new ListViewItem((i + 1).ToString(), i + 1);
                //user_item.SubItems.Add(user_list[i].UserName.ToString());
                user_item.SubItems.Add(user_list[i].Book_personid.ToString());
                user_item.SubItems.Add(user_list[i].Book_person.ToString());
                user_item.SubItems.Add(user_list[i].yARDID.ToString());
                user_item.SubItems.Add(user_list[i].OpenTime.ToString());
                user_item.SubItems.Add(user_list[i].CloseTime.ToString());
                user_item.SubItems.Add(user_list[i].BookDate.ToString());
                user_item.SubItems.Add(user_list[i].REALDate.ToString());
                user_item.SubItems.Add(user_list[i].Tel.ToString());
                user_item.SubItems.Add(user_list[i].BookCondition.ToString());
                listView1.Items.Add(user_item);
            }
        }

        public void countmoney()
        {
            //此方法用于计算用户租赁场地的花销
            //获取listview中的开始时间和结束时间，计算时间差。
            //用户花的钱 = 时间差*对应场地单价+（违约金）
            //违约金 = （时间差*对应场地单价）*0.3
            //是否需要缴纳违约金看用户的BreakBJ标记是否为YES 为YES，加收，不为YES，不收

            //先根据选取的场地id获取对应的场地价格
            Yard jiage = new Yard();
            chloe_control_all chloe_price = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            jiage = chloe_price.catchprice(comboBox1.SelectedValue.ToString()); // （）调用的是控件comboBox的值，即场地id
            double cdprice;
            cdprice = jiage.Price;
            //再根据场地id获取对应列的开始时间和结束时间
            Start waailu = new Start();
            String chalang = Start.CUser;
            Booking leihou = new Booking();
            chloe_control_all chloe_time = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            leihou = chloe_time.See_BOOK_CD(comboBox1.SelectedValue.ToString());
            //开始时间、结束时间、中午、下午（用于计算和转换）
            String START, EXIT, MID, AFT;
            START = leihou.OpenTime.ToString();
            EXIT = leihou.CloseTime.ToString();
            MID = mid;
            AFT = aft;
            DateTime dt1 = Convert.ToDateTime(START);
            DateTime dt2 = Convert.ToDateTime(EXIT);
            DateTime dt3 = Convert.ToDateTime(MID);
            DateTime dt4 = Convert.ToDateTime(AFT);
            TimeSpan ts1 = new TimeSpan(dt1.Ticks);
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);
            TimeSpan ts3 = new TimeSpan(dt3.Ticks);
            TimeSpan ts4 = new TimeSpan(dt4.Ticks);
            //计算时间差（然后计算两个TimeSpan的差）
            //时间计算还得区分中午12:00-下午14:00这两个小时的休息时间
            //如果选择的开始时间小于等于12:00以及结束的时间大于等于14:00，实际的消费时间为（12:00-开始时间）+ （结束时间-14:00）
            String ALLtime; //计算出来的时间差
            if (DateTime.Compare(dt1, dt3) <= 0 && DateTime.Compare(dt2, dt4) >= 0)
            {
                TimeSpan ts5 = ts1.Subtract(ts3).Duration();//（12:00-开始时间）
                TimeSpan ts6 = ts2.Subtract(ts4).Duration();//（结束时间-14:00）
                TimeSpan ts7 = ts5.Add(ts6).Duration(); //实际的消费时间
                double t = ts7.TotalHours / Convert.ToDouble(1); //将TimeSpan转换类型，便于后期计算费用,精确至小数点后两位
                double t1 = Convert.ToDouble(t);
                ALLtime = t1.ToString();
            }
            else
            {
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                double m = ts.TotalHours / Convert.ToDouble(1);
                double m1 = Convert.ToDouble(m);
                ALLtime = m1.ToString();
            }
            //判断用户标记，计算不同的钱
            //Visa代表违约用户的总金额 VISA代表正常用户的总金额
            //MMMM代表总金额
            double Visa, VISA;
            int BJ_check_result;
            BJ_check_result = chloe_time.USER_CHECK(chalang);
            if (BJ_check_result == 0) //用户违约用户，需收取违约金
            {
                Visa = double.Parse(ALLtime) * cdprice * 1.3;
                MMMM = Visa.ToString();
            }
            else
            {
                VISA = double.Parse(ALLtime) * cdprice;
                MMMM = VISA.ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //选择好场地id和日期后，点击支付按钮，先判断其有无奖励或者违规标记，有奖励，弹窗提示免单，然后将该条数据保存在PAY表，然后删除该条数据
            //将用户的免单标记值修改为NO
            //有违规，弹窗显示其为存在违规，需加收违约金，然后弹窗显示支付金额，进入扫码支付界面进行支付，正常付钱，将数据写进PAY表，删除Booking表中该条数据
            //支付不正常，将数据写进PAY表，Booking表对应数据不删除
            //返回时，还原其标记值
            //为普通用户，弹窗显示支付金额，进入扫码支付界面进行支付，后面如上。

            //判断用户
            Start NE21 = new Start();
            String NE22 = Start.CUser;
            chloe_control_all chloe_obj1 = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            Booking BigBang = new Booking();
            BigBang = chloe_obj1.See_BOOK_CD(comboBox1.SelectedValue.ToString());
            int BJ_check_result;
            BJ_check_result = chloe_obj1.User_checkkkkk(NE22);
            if (BJ_check_result == 3)   //该值为3时是奖励用户
            {
                MessageBox.Show("您为奖励用户，已为您本次消费免单！");
                String pay_id, pay_name, yard_id, begin_time, over_time, book_time, real_time, pay_money;
                DateTime pay_time;
                pay_id = BigBang.Book_personid.ToString();
                pay_name = BigBang.Book_person.ToString();
                yard_id = comboBox1.SelectedValue.ToString();
                begin_time = BigBang.OpenTime.ToString();
                over_time = BigBang.CloseTime.ToString();
                book_time = BigBang.BookDate.ToString();
                real_time = BigBang.REALDate.ToLongDateString().ToString();
                pay_money = (Paymoney).Trim().ToString();
                pay_time = DateTime.Now;
                chloe_control_all chloe_obj2 = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
                chloe_obj2.UserPay(pay_id, pay_name, yard_id, begin_time, over_time, book_time, real_time, pay_money, pay_time);
                Booking del = new Booking();
                User_BJ bj = new User_BJ();
                chloe_control_all chloe_del = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
                chloe_obj2.QUXIAO_YD(comboBox1.SelectedValue.ToString());
                chloe_del.XG_BJ(NE22);
            }
            else 
            {
                //违规用户
                int bj_result;
                bj_result = chloe_obj1.USER_CHECK(NE22);
                if (bj_result == 0)
                {
                    countmoney();
                    MessageBox.Show("系统检测到您为违约用户，需在本次消费中收取违约金");                                     
                    MessageBox.Show("您需要支付："  + MMMM.ToString() + "元");
                    Count_pay2 br = new Count_pay2();
                    CHANGDI = comboBox1.SelectedValue.ToString();
                    this.Hide();
                    br.Show();
                }
                //正常用户
                countmoney();
                MessageBox.Show("您需要支付："  + MMMM.ToString() + "元");                
                Count_pay2 nor = new Count_pay2();
                CHANGDI = comboBox1.SelectedValue.ToString();
                this.Hide();
                nor.Show();
            }
        }
    }
}
