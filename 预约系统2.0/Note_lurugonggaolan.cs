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
    public partial class Note_lurugonggaolan : Form
    {
        public Note_lurugonggaolan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String noteid, title, information;
            DateTime notetime;
            noteid = textBox1.Text;
            title = textBox2.Text;
            information = textBox3.Text;
            notetime = DateTime.Now;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.inser_ggcontent(int.Parse(noteid), title, information, notetime);
        }
    }
}
