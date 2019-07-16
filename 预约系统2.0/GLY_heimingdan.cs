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
    public partial class GLY_heimingdan : Form
    {
        public GLY_heimingdan()
        {
            InitializeComponent();
        }
        private void GLY_heimingdan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet9.HMD”中。您可以根据需要移动或删除它。
            this.hMDTableAdapter.Fill(this.场馆预约系统DataSet9.HMD);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet8.Login”中。您可以根据需要移动或删除它。
            this.loginTableAdapter1.Fill(this.场馆预约系统DataSet8.Login);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String hmd_id, hmd_name;
            hmd_id = comboBox1.SelectedValue.ToString();
            hmd_name = comboBox2.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.inser_hmd(hmd_id, hmd_name);
            GLY_heimingdan_Load(null,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String select_name;
            select_name = comboBox3.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_hmd(select_name);
            GLY_heimingdan_Load(null, null);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_hmd_all();
            GLY_heimingdan_Load(null,null);
        }
    }
}
