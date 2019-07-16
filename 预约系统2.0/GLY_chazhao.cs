using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Chloe;
using Chloe.SqlServer;
using chloe_control_namespace;

namespace 预约系统2._0
{
    public partial class GLY_chazhao : Form
    {
        public GLY_chazhao()
        {
            InitializeComponent();
        }

        private void chazhao_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLY gly1 = new GLY();
            gly1.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            List<User_BJ> user_list = new List<User_BJ>();
            String Search1 = "";
            Search1 = (String)UserIDDD.SelectedItem;
            user_info_display.Items.Clear();            
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            user_list = chloe_obj.User_Search(Search1);           
            for (int i = 0; i < user_list.Count; i++)
            {
                ListViewItem user_item = new ListViewItem((i+1).ToString(),i+1);
                //user_item.SubItems.Add(user_list[i].UserName.ToString());
                user_item.SubItems.Add(user_list[i].UserName.ToString());
                user_item.SubItems.Add(user_list[i].Permissions.ToString());
                user_item.SubItems.Add(user_list[i].BreakTime.ToString());
                user_item.SubItems.Add(user_list[i].Forbid.ToString());
                user_item.SubItems.Add(user_list[i].Award.ToString());
                user_item.SubItems.Add(user_list[i].BreakBJ.ToString());
                user_info_display.Items.Add(user_item);
            }  
        }
    }
}
