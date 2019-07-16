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
    public partial class Note_chakan : Form
    {
        public Note_chakan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void Note_chakan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet6.GGContent”中。您可以根据需要移动或删除它。
            this.gGContentTableAdapter.Fill(this.场馆预约系统DataSet6.GGContent);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet5.YardContent”中。您可以根据需要移动或删除它。
            this.yardContentTableAdapter.Fill(this.场馆预约系统DataSet5.YardContent);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet4.SystemContent”中。您可以根据需要移动或删除它。
            this.systemContentTableAdapter.Fill(this.场馆预约系统DataSet4.SystemContent);

        }
    }
}
