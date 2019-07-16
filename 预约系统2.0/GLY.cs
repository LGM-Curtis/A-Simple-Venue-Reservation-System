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
    public partial class GLY : Form
    {

        public GLY()
        {
            InitializeComponent();
        }

        private void QuitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLY_zhuce yh1 = new GLY_zhuce();
            this.Hide();
            yh1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            statusStrip1.Text = DateTime.Now.ToString();
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLY_chazhao cz = new GLY_chazhao();
            this.Hide();
            cz.Show();
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLY_xiugai xg = new GLY_xiugai();
            this.Hide();
            xg.Show();
        }

        private void 黑名单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLY_heimingdan hmd = new GLY_heimingdan();
            this.Hide();
            hmd.Show();
        }

        private void 录入场地信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yard_luru lr = new Yard_luru();
            this.Hide();
            lr.Show();
        }

        private void 场地信息查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yard_chakan CZ = new Yard_chakan();
            this.Hide();
            CZ.Show();
        }

        private void 修改场地信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yard_xiugai XG = new Yard_xiugai();
            this.Hide();
            XG.Show();
        }

        private void 系统通知ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Note_luruxitong xt = new Note_luruxitong();
            this.Hide();
            xt.Show();
        }

        private void 场地通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_lurucangdi cd = new Note_lurucangdi();
            this.Hide();
            cd.Show();
        }

        private void 公告栏通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_lurugonggaolan ggl = new Note_lurugonggaolan();
            this.Hide();
            ggl.Show();
        }

        private void 查找通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_chakan cztz = new Note_chakan();
            this.Hide();
            cztz.Show();
        }

        private void 修改通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_qingli xgtz = new Note_qingli();
            this.Hide();
            xgtz.Show();
        }

        private void 已预约ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookcheck_result;
            chloe_control_all chloe_obj = new chloe_control_all("Data Source=DESKTOP-O4C25KM;Initial Catalog=场馆预约系统;Integrated Security=True");
            bookcheck_result = chloe_obj.gly_book_find();
            if (bookcheck_result == 0)
            {
                MessageBox.Show("暂无用户预约场地，请过几分钟再来！");
            }
            else
            {            
                GLY_yiyuyue YYY = new GLY_yiyuyue();
                this.Hide();
                YYY.Show();
            }
        }

        private void 举报信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FK_jubao JB = new FK_jubao();
            this.Hide();
            JB.Show();
        }

        private void 建议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FK_jianyi JY = new FK_jianyi();
            this.Hide();
            JY.Show();
        }

        private void 查看支付情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLY_check_PAY ZF = new GLY_check_PAY();
            this.Hide();
            ZF.Show();
        }
    }
}
