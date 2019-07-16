namespace 预约系统2._0
{
    partial class YH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YH));
            this.label1 = new System.Windows.Forms.Label();
            this.Quitsystem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.场地通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公告栏通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看场地ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提出建议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.举报违规行为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test结算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(99, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用场馆预约系统";
            // 
            // Quitsystem
            // 
            this.Quitsystem.BackColor = System.Drawing.Color.White;
            this.Quitsystem.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Quitsystem.ForeColor = System.Drawing.Color.Black;
            this.Quitsystem.Location = new System.Drawing.Point(287, 405);
            this.Quitsystem.Name = "Quitsystem";
            this.Quitsystem.Size = new System.Drawing.Size(157, 41);
            this.Quitsystem.TabIndex = 11;
            this.Quitsystem.Text = "退出系统";
            this.Quitsystem.UseVisualStyleBackColor = false;
            this.Quitsystem.Click += new System.EventHandler(this.Quitsystem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 268);
            this.label2.TabIndex = 12;
            this.label2.Text = "请遵守以下准则：\r\n1.强烈建议您预约场地时请先看通知，了解场地情况后再作预约！\r\n2.如果您临时有事未能按预约时间到达场地，请您及时取消预约！如果您未取消预约，" +
    "将视作违约。\r\n3.一周内违约次数累积3次，将被拉入黑名单，禁止预约时间为一周。";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息ToolStripMenuItem,
            this.查看通知ToolStripMenuItem,
            this.查看场地ToolStripMenuItem,
            this.test取消ToolStripMenuItem,
            this.test结算ToolStripMenuItem,
            this.提出建议ToolStripMenuItem,
            this.举报违规行为ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.修改个人信息ToolStripMenuItem});
            this.用户信息ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.用户信息ToolStripMenuItem.Text = "查看用户信息";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看ToolStripMenuItem.Text = "查看个人信息";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            this.修改个人信息ToolStripMenuItem.Click += new System.EventHandler(this.修改个人信息ToolStripMenuItem_Click);
            // 
            // 查看通知ToolStripMenuItem
            // 
            this.查看通知ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统通知ToolStripMenuItem,
            this.场地通知ToolStripMenuItem,
            this.公告栏通知ToolStripMenuItem});
            this.查看通知ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查看通知ToolStripMenuItem.Name = "查看通知ToolStripMenuItem";
            this.查看通知ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.查看通知ToolStripMenuItem.Text = "查看通知";
            // 
            // 系统通知ToolStripMenuItem
            // 
            this.系统通知ToolStripMenuItem.Name = "系统通知ToolStripMenuItem";
            this.系统通知ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.系统通知ToolStripMenuItem.Text = "系统通知";
            this.系统通知ToolStripMenuItem.Click += new System.EventHandler(this.系统通知ToolStripMenuItem_Click);
            // 
            // 场地通知ToolStripMenuItem
            // 
            this.场地通知ToolStripMenuItem.Name = "场地通知ToolStripMenuItem";
            this.场地通知ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.场地通知ToolStripMenuItem.Text = "场地通知";
            this.场地通知ToolStripMenuItem.Click += new System.EventHandler(this.场地通知ToolStripMenuItem_Click);
            // 
            // 公告栏通知ToolStripMenuItem
            // 
            this.公告栏通知ToolStripMenuItem.Name = "公告栏通知ToolStripMenuItem";
            this.公告栏通知ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.公告栏通知ToolStripMenuItem.Text = "公告栏通知";
            this.公告栏通知ToolStripMenuItem.Click += new System.EventHandler(this.公告栏通知ToolStripMenuItem_Click);
            // 
            // 查看场地ToolStripMenuItem
            // 
            this.查看场地ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查看场地ToolStripMenuItem.Name = "查看场地ToolStripMenuItem";
            this.查看场地ToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.查看场地ToolStripMenuItem.Text = "查看场地信息及预订";
            this.查看场地ToolStripMenuItem.Click += new System.EventHandler(this.查看场地ToolStripMenuItem_Click);
            // 
            // test取消ToolStripMenuItem
            // 
            this.test取消ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.test取消ToolStripMenuItem.Name = "test取消ToolStripMenuItem";
            this.test取消ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.test取消ToolStripMenuItem.Text = "取消预订";
            this.test取消ToolStripMenuItem.Click += new System.EventHandler(this.test取消ToolStripMenuItem_Click);
            // 
            // 提出建议ToolStripMenuItem
            // 
            this.提出建议ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.提出建议ToolStripMenuItem.Name = "提出建议ToolStripMenuItem";
            this.提出建议ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.提出建议ToolStripMenuItem.Text = "建议中心";
            this.提出建议ToolStripMenuItem.Click += new System.EventHandler(this.提出建议ToolStripMenuItem_Click);
            // 
            // 举报违规行为ToolStripMenuItem
            // 
            this.举报违规行为ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.举报违规行为ToolStripMenuItem.Name = "举报违规行为ToolStripMenuItem";
            this.举报违规行为ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.举报违规行为ToolStripMenuItem.Text = "举报中心";
            this.举报违规行为ToolStripMenuItem.Click += new System.EventHandler(this.举报违规行为ToolStripMenuItem_Click);
            // 
            // test结算ToolStripMenuItem
            // 
            this.test结算ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.test结算ToolStripMenuItem.Name = "test结算ToolStripMenuItem";
            this.test结算ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.test结算ToolStripMenuItem.Text = "用户结算";
            this.test结算ToolStripMenuItem.Click += new System.EventHandler(this.test结算ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // YH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(771, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quitsystem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YH";
            this.Text = "场馆预约系统";
            this.Load += new System.EventHandler(this.YH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quitsystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看场地ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看通知ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 提出建议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 举报违规行为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 场地通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公告栏通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test取消ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test结算ToolStripMenuItem;
    }
}