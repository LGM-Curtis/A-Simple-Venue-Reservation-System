﻿using System;
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
    public partial class YH_KanNote_GGL : Form
    {
        public YH_KanNote_GGL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YH yh1 = new YH();
            yh1.ShowDialog();
        }

        private void YH_KanNote_GGL_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“场馆预约系统DataSet6.GGContent”中。您可以根据需要移动或删除它。
            this.gGContentTableAdapter.Fill(this.场馆预约系统DataSet6.GGContent);

        }
    }
}
