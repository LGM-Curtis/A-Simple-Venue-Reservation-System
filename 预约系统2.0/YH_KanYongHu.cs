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
    public partial class YH_KanYongHu : Form
    {
        public YH_KanYongHu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YH yh1 = new YH();
            yh1.Show();
        }

        private void YH_KanYongHu_Load(object sender, EventArgs e)
        {
            Start SS = new Start();
            String oo = Start.CUser;
            Login user_info = new Login();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            user_info = chloe_obj.See_myself(oo);
            user_id.Text = user_info.UserName;
            user_name.Text = user_info.RealName;
            user_tel.Text = user_info.Tel;

        }
    }
}
