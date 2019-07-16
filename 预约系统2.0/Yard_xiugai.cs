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
    public partial class Yard_xiugai : Form
    {
        public Yard_xiugai()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }

        private void Yard_xiugai_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet14.Yard”中。您可以根据需要移动或删除它。
            this.yardTableAdapter.Fill(this.场馆预约系统DataSet14.Yard);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet11.YardName”中。您可以根据需要移动或删除它。
            this.yardNameTableAdapter.Fill(this.场馆预约系统DataSet11.YardName);
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet10.YardAddress”中。您可以根据需要移动或删除它。
            this.yardAddressTableAdapter.Fill(this.场馆预约系统DataSet10.YardAddress);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox5.Text == "" )
            {
                MessageBox.Show("请正确输入信息");
                return;
                
            }
            String id, name, address, time;int price;
            id = textbox1.Text;
            name = textbox2.Text;
            address = textbox3.Text;
            time = textbox4.Text;
            price = int.Parse(textbox5.Text);
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.Yard_XG(id,name,address,time,price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String select_Yard_ID;
            select_Yard_ID = comboBox1.SelectedValue.ToString();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.del_Yard(select_Yard_ID);
            Yard_xiugai_Load(null, null);
        }
    }
}
