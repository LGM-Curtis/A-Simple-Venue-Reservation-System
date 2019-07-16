using chloe_control_namespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 预约系统2._0
{
    public partial class YH_quxiao : Form
    {
        public YH_quxiao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YH yh1 = new YH();
            this.Hide();
            yh1.Show();
        }

        //查询语句
        /*
        public DataTable SelectYardid()
        {
            Start ioj = new Start();
            String iu = Start.CUser;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            conn.Open();
            string sql = "select yARDID from Booking where book_personid='" + iu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            cmd.Dispose();
            return dt;
            
        }
        */


        private void Test_QX_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet17.Booking”中。您可以根据需要移动或删除它。
            this.bookingTableAdapter.Fill(this.场馆预约系统DataSet17.Booking);

            //comboBox1.DataSource = SelectYardid();//绑定数据
            //comboBox1.DisplayMember = "yARDID";

            Start ll = new Start();
            String LL = Start.CUser;
            List<Booking> user_list = new List<Booking>();
            listView1.Items.Clear();
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            user_list = chloe_obj.person_search(LL);
            for (int i = 0; i < user_list.Count; i++)
            {
                ListViewItem user_item = new ListViewItem((i+1).ToString(), i+1);
                //user_item.SubItems.Add(user_list[i].UserName.ToString());
                user_item.SubItems.Add(user_list[i].Book_personid.ToString());
                user_item.SubItems.Add(user_list[i].Book_person.ToString());
                user_item.SubItems.Add(user_list[i].yARDID.ToString());
                user_item.SubItems.Add(user_list[i].OpenTime.ToString());
                user_item.SubItems.Add(user_list[i].CloseTime.ToString());
                user_item.SubItems.Add(user_list[i].BookDate.ToString());
                user_item.SubItems.Add(user_list[i].REALDate.ToString());
                user_item.SubItems.Add(user_list[i].Tel.ToString());
                user_item.SubItems.Add(user_list[i].BookCondition.ToString());
                listView1.Items.Add(user_item);               
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String book;
            book = comboBox1.SelectedValue.ToString();              
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            chloe_obj.QUXIAO_YD(book);
            Test_QX_Load(null, null);
        }
    }
}
