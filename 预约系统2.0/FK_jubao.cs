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
    public partial class FK_jubao : Form
    {
        public FK_jubao()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void FK_jubao_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet19.YH_JuBao”中。您可以根据需要移动或删除它。
            this.yH_JuBaoTableAdapter.Fill(this.场馆预约系统DataSet19.YH_JuBao);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_jubao_all();
            FK_jubao_Load(null, null);
        }
    }
}
