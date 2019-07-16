using Chloe.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 预约系统2._0
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        public static string CUser;

        private void button1_Click(object sender, EventArgs e)
        {
            if (USERNAME.Text.Trim() == "" | PASSWORD.Text.Trim() == "")
            {
                MessageBox.Show("用户名跟密码不能为空");
                return;
            }
            else
            {
                if (USERNAME.Text.Trim() == "TEST" && PASSWORD.Text.Trim() == "123")
                {
                    ONLY_ADD_USER creat_user = new ONLY_ADD_USER();
                    this.Hide();
                    MessageBox.Show("请根据要求填写好注册信息！");
                    creat_user.ShowDialog();
                    return;
                }
                else
                {
                    int login_result;
                    chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
                    login_result = chloe_obj.login_check(USERNAME.Text, PASSWORD.Text);

                    if (login_result == 0)
                    {
                        MessageBox.Show("登录失败!  1.该用户不存在！2.您填写的用户名或密码有误！请重新输入！");
                        return;
                    }
                    if (login_result == 3)
                    {
                        MessageBox.Show("禁止使用本系统！请在解禁后登录！");
                        return;
                    }
                        if (login_result == 1)
                        {
                             GLY gly = new GLY();
                             this.Hide();
                             CUser = USERNAME.Text.ToString().Trim();
                             MessageBox.Show("欢迎管理员");
                             gly.ShowDialog();
                             return;
                        }
                        else if (login_result == 2)
                        {
                             YH yh = new YH();
                             this.Hide();
                             CUser = USERNAME.Text.ToString().Trim();
                             MessageBox.Show("欢迎使用广东理工学院场馆预约系统！");
                             MessageBox.Show("请遵守以下准则：1.强烈建议您预约场地时请先看通知，了解场地情况后再作预约！2.如果您临时有事未能按预约时间到达场地，请您及时取消预约！如果您未取消预约，且未到达场地的，将视作违约。3.一周内违约次数累积3次，将被拉入黑名单，禁止预约时间为一周。");
                             yh.ShowDialog();
                             return;
                        }
                    }                   
                }
         }

        //重置两个框中输入的内容   
        private void CLEAR_Click(object sender, EventArgs e)
        {
            USERNAME.Clear();
            PASSWORD.Clear();
        }
    }
}

