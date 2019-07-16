namespace 预约系统2._0
{
    partial class GLY_yiyuyue
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.场馆预约系统DataSet17 = new 预约系统2._0.场馆预约系统DataSet17();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new 预约系统2._0.场馆预约系统DataSet17TableAdapters.BookingTableAdapter();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpersonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yARDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEALDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDDataGridViewTextBoxColumn,
            this.bookpersonidDataGridViewTextBoxColumn,
            this.bookpersonDataGridViewTextBoxColumn,
            this.yARDIDDataGridViewTextBoxColumn,
            this.openTimeDataGridViewTextBoxColumn,
            this.closeTimeDataGridViewTextBoxColumn,
            this.bookDateDataGridViewTextBoxColumn,
            this.rEALDateDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.bookConditionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(568, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(790, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户预约信息表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "删除用户预约信息";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bookingBindingSource;
            this.comboBox1.DisplayMember = "Book_personid";
            this.comboBox1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(330, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 29);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Book_personid";
            // 
            // 场馆预约系统DataSet17
            // 
            this.场馆预约系统DataSet17.DataSetName = "场馆预约系统DataSet17";
            this.场馆预约系统DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.场馆预约系统DataSet17;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.场馆预约系统DataSet17;
            // 
            // idDDataGridViewTextBoxColumn
            // 
            this.idDDataGridViewTextBoxColumn.DataPropertyName = "IdD";
            this.idDDataGridViewTextBoxColumn.HeaderText = "IdD";
            this.idDDataGridViewTextBoxColumn.Name = "idDDataGridViewTextBoxColumn";
            this.idDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookpersonidDataGridViewTextBoxColumn
            // 
            this.bookpersonidDataGridViewTextBoxColumn.DataPropertyName = "Book_personid";
            this.bookpersonidDataGridViewTextBoxColumn.HeaderText = "Book_personid";
            this.bookpersonidDataGridViewTextBoxColumn.Name = "bookpersonidDataGridViewTextBoxColumn";
            // 
            // bookpersonDataGridViewTextBoxColumn
            // 
            this.bookpersonDataGridViewTextBoxColumn.DataPropertyName = "Book_person";
            this.bookpersonDataGridViewTextBoxColumn.HeaderText = "Book_person";
            this.bookpersonDataGridViewTextBoxColumn.Name = "bookpersonDataGridViewTextBoxColumn";
            // 
            // yARDIDDataGridViewTextBoxColumn
            // 
            this.yARDIDDataGridViewTextBoxColumn.DataPropertyName = "yARDID";
            this.yARDIDDataGridViewTextBoxColumn.HeaderText = "yARDID";
            this.yARDIDDataGridViewTextBoxColumn.Name = "yARDIDDataGridViewTextBoxColumn";
            // 
            // openTimeDataGridViewTextBoxColumn
            // 
            this.openTimeDataGridViewTextBoxColumn.DataPropertyName = "OpenTime";
            this.openTimeDataGridViewTextBoxColumn.HeaderText = "OpenTime";
            this.openTimeDataGridViewTextBoxColumn.Name = "openTimeDataGridViewTextBoxColumn";
            // 
            // closeTimeDataGridViewTextBoxColumn
            // 
            this.closeTimeDataGridViewTextBoxColumn.DataPropertyName = "CloseTime";
            this.closeTimeDataGridViewTextBoxColumn.HeaderText = "CloseTime";
            this.closeTimeDataGridViewTextBoxColumn.Name = "closeTimeDataGridViewTextBoxColumn";
            // 
            // bookDateDataGridViewTextBoxColumn
            // 
            this.bookDateDataGridViewTextBoxColumn.DataPropertyName = "BookDate";
            this.bookDateDataGridViewTextBoxColumn.HeaderText = "BookDate";
            this.bookDateDataGridViewTextBoxColumn.Name = "bookDateDataGridViewTextBoxColumn";
            // 
            // rEALDateDataGridViewTextBoxColumn
            // 
            this.rEALDateDataGridViewTextBoxColumn.DataPropertyName = "REALDate";
            this.rEALDateDataGridViewTextBoxColumn.HeaderText = "REALDate";
            this.rEALDateDataGridViewTextBoxColumn.Name = "rEALDateDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // bookConditionDataGridViewTextBoxColumn
            // 
            this.bookConditionDataGridViewTextBoxColumn.DataPropertyName = "BookCondition";
            this.bookConditionDataGridViewTextBoxColumn.HeaderText = "BookCondition";
            this.bookConditionDataGridViewTextBoxColumn.Name = "bookConditionDataGridViewTextBoxColumn";
            // 
            // GLY_yiyuyue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 498);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GLY_yiyuyue";
            this.Text = "GLY_yiyuyue";
            this.Load += new System.EventHandler(this.GLY_yiyuyue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private 场馆预约系统DataSet17 场馆预约系统DataSet17;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private 场馆预约系统DataSet17TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpersonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yARDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEALDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
    }
}