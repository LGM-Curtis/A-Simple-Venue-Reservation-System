using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chloe;
using Chloe.SqlServer;
using chloe_control_namespace;

namespace 预约系统2._0
{
    public partial class GLY_zhuce : Form
    {
        public GLY_zhuce()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
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

            String user_id, user_password, user_name, tel; int permissions;
                user_id = textBox1.Text;
                user_password = textBox2.Text;
            permissions = int.Parse(textBox4.Text);
                user_name = textBox5.Text;
                tel = textBox6.Text;
                chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
                chloe_obj.insert_user1(user_id, user_password,user_name,tel);
            chloe_obj.insert_user2(user_id,permissions);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Find_result;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            Find_result = chloe_obj.user_find(textBox1.Text);
            if (Find_result == 0)
            {
                MessageBox.Show("该用户名可以使用！");
            }
            else if (Find_result == 1)
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
            textBox6.Clear();
        }
    }
}
       