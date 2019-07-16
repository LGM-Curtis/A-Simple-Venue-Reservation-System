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
    public partial class YH_Report : Form
    {
        public YH_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YH yh1 = new YH();
            yh1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String neirong;
            DateTime writetime;
            neirong = textBox1.Text;
            writetime = DateTime.Now;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.inser_jubao(neirong, writetime);
            MessageBox.Show("已收到您的举报！我们会派专人进行调查，1-3个工作日内会通过电话联系您的，请您保持手机通话畅通！");
        }
    }
}
