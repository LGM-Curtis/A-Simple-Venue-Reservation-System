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
    public partial class GLY_xiugai : Form
    {
        public GLY_xiugai()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void GLY_xiugai_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet8.Login”中。您可以根据需要移动或删除它。
            this.loginTableAdapter.Fill(this.场馆预约系统DataSet8.Login);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String select_yh_name;
            select_yh_name = comboBox1.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_YH(select_yh_name);
            GLY_xiugai_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int YH_quanxian, YH_breaktime;
            String YH_id,YH_forbid, YH_award, YH_breakbj;
            if (textBox3.Text == ""|textBox6.Text == "")
            {
                MessageBox.Show("请正确输入信息！");
                return;
            }
            YH_quanxian = int.Parse(textBox3.Text);
            YH_breaktime = int.Parse(textBox6.Text);
            YH_id = textBox1.Text;
            YH_forbid = textBox7.Text;
            YH_award = textBox8.Text;
            YH_breakbj = textBox2.Text;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.XG_YH(YH_id,YH_quanxian,YH_breaktime,YH_forbid,YH_award,YH_breakbj);
        }
    }
}
