namespace 预约系统2._0
{
    partial class FK_jianyi
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.场馆预约系统DataSet18 = new 预约系统2._0.场馆预约系统DataSet18();
            this.yHSuggestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yH_SuggestTableAdapter = new 预约系统2._0.场馆预约系统DataSet18TableAdapters.YH_SuggestTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neiRongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yHSuggestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(164, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "清空所有";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(294, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.neiRongDataGridViewTextBoxColumn,
            this.writeTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yHSuggestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(542, 375);
            this.dataGridView1.TabIndex = 4;
            // 
            // 场馆预约系统DataSet18
            // 
            this.场馆预约系统DataSet18.DataSetName = "场馆预约系统DataSet18";
            this.场馆预约系统DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yHSuggestBindingSource
            // 
            this.yHSuggestBindingSource.DataMember = "YH_Suggest";
            this.yHSuggestBindingSource.DataSource = this.场馆预约系统DataSet18;
            // 
            // yH_SuggestTableAdapter
            // 
            this.yH_SuggestTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // neiRongDataGridViewTextBoxColumn
            // 
            this.neiRongDataGridViewTextBoxColumn.DataPropertyName = "NeiRong";
            this.neiRongDataGridViewTextBoxColumn.HeaderText = "NeiRong";
            this.neiRongDataGridViewTextBoxColumn.Name = "neiRongDataGridViewTextBoxColumn";
            this.neiRongDataGridViewTextBoxColumn.Width = 150;
            // 
            // writeTimeDataGridViewTextBoxColumn
            // 
            this.writeTimeDataGridViewTextBoxColumn.DataPropertyName = "WriteTime";
            this.writeTimeDataGridViewTextBoxColumn.HeaderText = "WriteTime";
            this.writeTimeDataGridViewTextBoxColumn.Name = "writeTimeDataGridViewTextBoxColumn";
            this.writeTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // FK_jianyi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "FK_jianyi";
            this.Text = "建议";
            this.Load += new System.EventHandler(this.FK_jianyi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yHSuggestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 场馆预约系统DataSet18 场馆预约系统DataSet18;
        private System.Windows.Forms.BindingSource yHSuggestBindingSource;
        private 场馆预约系统DataSet18TableAdapters.YH_SuggestTableAdapter yH_SuggestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neiRongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeTimeDataGridViewTextBoxColumn;
    }
}