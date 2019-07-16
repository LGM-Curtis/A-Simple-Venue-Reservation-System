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
    public partial class ONLY_ADD_USER : Form
    {
        public ONLY_ADD_USER()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请填写用户名！");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            if (textBox2.Text.Trim() != textBox3.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return;
            }
            String user_id, user_password, user_name, tel;
            user_id = textBox1.Text;
            user_password = textBox2.Text;
            user_name = textBox4.Text;
            tel = textBox5.Text;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.YH_insert_user1(user_id, user_password, user_name, tel);
            chloe_obj.YH_insert_user2(user_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userFind_result;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            userFind_result = chloe_obj.username_find(textBox1.Text);
            if (userFind_result == 0)
            {
                MessageBox.Show("该用户名可以使用！");
            }
            else if (userFind_result == 1)
            {
                MessageBox.Show("该用户名已被注册，请重新输入");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start zz = new Start();
            zz.ShowDialog();
        }
    }
}
