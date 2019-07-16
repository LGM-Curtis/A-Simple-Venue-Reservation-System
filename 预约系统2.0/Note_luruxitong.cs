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
    public partial class Note_luruxitong : Form
    {
        public Note_luruxitong()
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
            String noteid,title,information;
            DateTime notetime;
            noteid = TZID.Text;
            title = BT.Text;
            information = TZNR.Text;
            notetime = DateTime.Now;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.inser_systemcontent(int.Parse(noteid),title,information, notetime);
        }
    }
}
