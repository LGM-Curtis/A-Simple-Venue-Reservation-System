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
    public partial class GLY_check_PAY : Form
    {
        public GLY_check_PAY()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            GLY gly1 = new GLY();
            gly1.Show();
        }

        private void GLY_check_PAY_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet17.Booking”中。您可以根据需要移动或删除它。
            this.bookingTableAdapter.Fill(this.场馆预约系统DataSet17.Booking);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet16.PAY”中。您可以根据需要移动或删除它。
            this.pAYTableAdapter.Fill(this.场馆预约系统DataSet16.PAY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pay_id;
            pay_id = comboBox1.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_pay(pay_id);
            GLY_check_PAY_Load(null, null);
        }
    }
}
