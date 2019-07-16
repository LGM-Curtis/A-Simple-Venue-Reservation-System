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
    public partial class Yard_luru : Form
    {
        public Yard_luru()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YARDID.Clear();
            YARDNAMEID.Clear();
            YARDADDRESSID.Clear();
            OPENTIME.Clear();
            PRICE.Clear();
            BOOKCONDITION.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (YARDID.Text == "" && YARDADDRESSID.Text == "" && YARDNAMEID.Text == "" && OPENTIME.Text == "" && PRICE.Text == "" && BOOKCONDITION.Text == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {            
            String yardid, yardnameid, yardaddressid, opentime, price, bookcondition;
             yardid = YARDID.Text;
            yardnameid = YARDNAMEID.Text;
            yardaddressid = YARDADDRESSID.Text;
            opentime = OPENTIME.Text;
            price = PRICE.Text;
            bookcondition = BOOKCONDITION.Text;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.insert_yard(yardid, yardnameid, yardaddressid, opentime, int.Parse(price));
            }
        }
    }
}
