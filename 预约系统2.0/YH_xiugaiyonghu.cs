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
    public partial class YH_xiugaiyonghu : Form
    {
        public YH_xiugaiyonghu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YH yh1 = new YH();
            yh1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            if (textBox1.Text.Trim() != textBox2.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return;
            }
            String yh_password ,yh_name,yh_tel;
            yh_password = textBox1.Text;
            yh_name = textBox3.Text;
            yh_tel = textBox4.Text;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.xiugai_yh(yh_password,yh_name, yh_tel);
        }
    }
}
