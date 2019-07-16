using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chloe_control_namespace;

namespace 预约系统2._0
{
    public partial class YH_YuDingYard : Form
    {
        public YH_YuDingYard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YH yh1 = new YH();
            yh1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //预订场地（insert Booking表）
            String Yardid, oPentime, CLosetime, personname,tell,BJ ,Bookdate;
            DateTime rEaltime;
            //用户使用时，一定要全部都选好填好再点击预订。
            Yardid = (comboBox1.SelectedValue).ToString();
            oPentime = (comboBox2.SelectedItem).ToString();
            CLosetime = (comboBox3.SelectedItem).ToString();
            //判断预约时间的前后是否正确
            DateTime dt1 = Convert.ToDateTime(oPentime);
            DateTime dt2 = Convert.ToDateTime(CLosetime);
            if (DateTime.Compare(dt1, dt2) > 0)
            {
                MessageBox.Show("请选择正确的时间段");
            }
            if (DateTime.Compare(dt1, dt2) == 0)
            {
                MessageBox.Show("不能选相同的时间！请重新时间段");
            }
            if (textBox2.Text.Trim() == "" | textBox3.Text.Trim() == ""| Yardid.ToString() == "" )
            {
                MessageBox.Show("请填写好您的信息！不能为空噢！");
            }
            else
            {
                personname = textBox2.Text;
                tell = textBox3.Text;
                Bookdate = dateTimePicker1.Value.ToString();
                rEaltime = DateTime.Now;
                BJ = "YES";
                DateTime dt3 = Convert.ToDateTime(Bookdate);
                if (DateTime.Compare(dt3, rEaltime) < 0)
                {
                    MessageBox.Show("不能选以前的日期噢！");
                }
                else
                {
                    int check_message_result;
                    String cd, st, ot, DAY;
                    cd = comboBox1.SelectedValue.ToString();
                    st = comboBox2.SelectedItem.ToString();
                    ot = comboBox3.SelectedItem.ToString();
                    DAY = dateTimePicker1.Value.ToString();
                    chloe_control_all chloe_obj_message = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
                    check_message_result = chloe_obj_message.checkbookmessage(cd, st, ot, DAY);
                    if (check_message_result == 0) //找不到重复的，直接预约
                    {
                        chloe_control_all chloe_obj1 = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
                        chloe_obj1.YH_BOOK_Yard(Yardid, oPentime, CLosetime, Bookdate, rEaltime, personname, tell, BJ);

                    }
                    else if (check_message_result == 1)
                    {
                        MessageBox.Show("该天该时间段该场地已被人预约，请选择其他时间段或选择其他场地或选择预约其他日期!");
                    }
                    
                }               
            }            
        }

        private void YH_YuDingYard_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet10.YardAddress”中。您可以根据需要移动或删除它。
            this.yardAddressTableAdapter.Fill(this.场馆预约系统DataSet10.YardAddress);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet13.Yard”中。您可以根据需要移动或删除它。
            this.yardTableAdapter.Fill(this.场馆预约系统DataSet13.Yard);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet11.YardName”中。您可以根据需要移动或删除它。
            this.yardNameTableAdapter.Fill(this.场馆预约系统DataSet11.YardName);

        }
    }
}
