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
    public partial class Yard_chakan : Form
    {
        public Yard_chakan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void Yard_chazhao_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet13.Yard”中。您可以根据需要移动或删除它。
            this.yardTableAdapter1.Fill(this.场馆预约系统DataSet13.Yard);
        }
    }
}
