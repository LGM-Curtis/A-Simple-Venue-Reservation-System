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
    public partial class YH : Form
    {
        public YH()
        {
            InitializeComponent();
        }

        private void Quitsystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            statusStrip1.Text = DateTime.Now.ToString();
        }

        private void 查看场地ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_YuDingYard KCD = new YH_YuDingYard();
            this.Hide();
            KCD.Show();
        }

        private void 系统通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_KanNote_XT xt = new YH_KanNote_XT();
            this.Hide();
            xt.Show();
        }

        private void 场地通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_KanNote_CD cd = new YH_KanNote_CD();
            this.Hide();
            cd.Show();
        }

        private void 公告栏通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_KanNote_GGL ggl = new YH_KanNote_GGL();
            this.Hide();
            ggl.Show();
        }

        private void 提出建议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_Suggestion jy = new YH_Suggestion();
            this.Hide();
            jy.Show(); 
        }

        private void 举报违规行为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_Report jb = new YH_Report();
            this.Hide();
            jb.Show();
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_xiugaiyonghu xgyh = new YH_xiugaiyonghu();
                this.Hide();
            xgyh.Show();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YH_KanYongHu KK = new YH_KanYongHu();
            this.Hide();
            KK.Show();
        }
           
        private void YH_Load(object sender, EventArgs e)
        {

        }

        private void test取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start vv = new Start();
            String VV = Start.CUser;
            int bookcheck_result;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            bookcheck_result = chloe_obj.book_find(VV);
            if (bookcheck_result == 0)
            {
                MessageBox.Show("您还没有预约任意场地");
            }
            else
            {
                YH_quxiao qx = new YH_quxiao();
                this.Hide();
                qx.Show();
            }
        }

        private void test结算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start xb = new Start();
            String MM = Start.CUser;
            int jsuser_find;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            jsuser_find = chloe_obj.book_find(MM);
            if (jsuser_find == 0)
            {
                MessageBox.Show("您还没有预约任意场地,暂时没有结算信息！");
            }
            else
            {
                 YH_JS cm = new YH_JS();
                this.Hide();
                cm.Show();
            }
        }
    }
}
