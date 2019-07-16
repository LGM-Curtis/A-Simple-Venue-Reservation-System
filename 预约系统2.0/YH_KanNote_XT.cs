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
    public partial class YH_KanNote_XT : Form
    {
        public YH_KanNote_XT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YH yh1 = new YH();
            yh1.ShowDialog();
        }

        private void YH_KanNote_XT_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet4.SystemContent”中。您可以根据需要移动或删除它。
            this.systemContentTableAdapter.Fill(this.场馆预约系统DataSet4.SystemContent);

        }
    }
}
