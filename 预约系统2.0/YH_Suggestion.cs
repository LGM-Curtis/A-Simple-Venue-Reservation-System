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
    public partial class YH_Suggestion : Form
    {
        public YH_Suggestion()
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
            chloe_obj.inser_suggest(neirong, writetime);
            MessageBox.Show("感谢您的宝贵建议！");
        }
      }
}
