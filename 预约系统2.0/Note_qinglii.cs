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
    public partial class Note_qingli : Form
    {
        public Note_qingli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void Note_qingli_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet6.GGContent”中。您可以根据需要移动或删除它。
            this.gGContentTableAdapter.Fill(this.场馆预约系统DataSet6.GGContent);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet5.YardContent”中。您可以根据需要移动或删除它。
            this.yardContentTableAdapter.Fill(this.场馆预约系统DataSet5.YardContent);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet4.SystemContent”中。您可以根据需要移动或删除它。
            this.systemContentTableAdapter.Fill(this.场馆预约系统DataSet4.SystemContent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String select_name1;
            select_name1 = comboBox1.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_xt_note(select_name1);
            Note_qingli_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String select_name2;
            select_name2 = comboBox5.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_cd_note(select_name2);
            Note_qingli_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String select_name3;
            select_name3 = comboBox9.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_ggl_note(select_name3);
            Note_qingli_Load(null, null);
        }
    }
}
