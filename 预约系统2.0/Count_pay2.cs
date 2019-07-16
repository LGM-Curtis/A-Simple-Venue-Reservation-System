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
    public partial class Count_pay2 : Form
    {
        public Count_pay2()
        {
            InitializeComponent();
        }

        public static String PAYMONEY = "null";
       
        private void button2_Click(object sender, EventArgs e)
        {
            //对于支付有问题的用户，关闭信息窗后在PAY表增添对应信息，paymoney为"NULL"        
            YH_JS nm = new YH_JS();
            String iddc;
            iddc = YH_JS.CHANGDI;
            chloe_control_all chloe_usebook = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            Booking havewt = new Booking();
            havewt = chloe_usebook.See_BOOK_CD(iddc);
            String id_pay,name_pay,id_yard,time_begin,time_over,time_book,time_real,money_pay;
            DateTime time_pay;
            id_pay = havewt.Book_personid.ToString();
            name_pay = havewt.Book_person.ToString();
            id_yard = havewt.yARDID.ToString();
            time_begin = havewt.OpenTime.ToString();
            time_over = havewt.CloseTime.ToString();
            //预订时间 = Booking表中的BookDate
            time_book = havewt.BookDate.ToString();
            time_real = havewt.REALDate.ToLongDateString().ToString();
            money_pay = PAYMONEY.Trim().ToString();
            time_pay = DateTime.Now;
            chloe_control_all chloe_obj_haveproblem = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj_haveproblem.UserPay(id_pay,name_pay,id_yard,time_begin,time_over,time_book,time_real,money_pay,time_pay);
            MessageBox.Show("请联系系统管理员，管理员电话：132XXXXXXXX");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //对于正常支付的用户，关闭信息窗后在PAY表增添对应信息
            //调用Booking中的数据
            //删除对应Booking表的数据
            YH_JS mmp = new YH_JS();
            String iDDc;
            iDDc = YH_JS.CHANGDI;
            chloe_control_all chloe_usebook = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            Booking usebooking = new Booking();
            usebooking = chloe_usebook.See_BOOK_CD(iDDc);
            String pay_id, pay_name, yard_id, begin_time, over_time, book_time,real_time,pay_money;
            DateTime pay_time;
            pay_id = usebooking.Book_personid;
            pay_name = usebooking.Book_person;
            yard_id = usebooking.yARDID;
            begin_time = usebooking.OpenTime;
            over_time = usebooking.CloseTime;
            book_time = usebooking.BookDate.ToString();
            real_time = usebooking.REALDate.ToLongDateString();
            pay_money = YH_JS.MMMM;
            pay_time = DateTime.Now;
            chloe_control_all chloe_obj_noproblem = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj_noproblem.UserPay(pay_id, pay_name, yard_id, begin_time, over_time, book_time,real_time, pay_money, pay_time);
            MessageBox.Show("已收到您的支付费用，欢迎再次预约！");  
            Booking del = new Booking();
            chloe_control_all chloe_del = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_del.shoudaoqian(iDDc);       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //退出页面时，修改对应用户在User_BJ表中的BreakBJ和Award值（修改为"NO"）
            Start RR = new Start();
            String EE = Start.CUser;
            User_BJ bj = new User_BJ();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.XG_BJ(EE);
            this.Hide();
            YH yh2 = new YH();
            yh2.Show();
        }
    }
}
