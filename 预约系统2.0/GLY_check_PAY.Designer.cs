namespace 预约系统2._0
{
    partial class GLY_check_PAY
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begintimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet16 = new 预约系统2._0.场馆预约系统DataSet16();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pAYTableAdapter = new 预约系统2._0.场馆预约系统DataSet16TableAdapters.PAYTableAdapter();
            this.场馆预约系统DataSet17 = new 预约系统2._0.场馆预约系统DataSet17();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new 预约系统2._0.场馆预约系统DataSet17TableAdapters.BookingTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.payidDataGridViewTextBoxColumn,
            this.paynameDataGridViewTextBoxColumn,
            this.yardidDataGridViewTextBoxColumn1,
            this.begintimeDataGridViewTextBoxColumn,
            this.overtimeDataGridViewTextBoxColumn,
            this.booktimeDataGridViewTextBoxColumn,
            this.realTimeDataGridViewTextBoxColumn,
            this.paymoneyDataGridViewTextBoxColumn,
            this.paytimeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pAYBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1, 273);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1081, 185);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // payidDataGridViewTextBoxColumn
            // 
            this.payidDataGridViewTextBoxColumn.DataPropertyName = "payid";
            this.payidDataGridViewTextBoxColumn.HeaderText = "payid";
            this.payidDataGridViewTextBoxColumn.Name = "payidDataGridViewTextBoxColumn";
            // 
            // paynameDataGridViewTextBoxColumn
            // 
            this.paynameDataGridViewTextBoxColumn.DataPropertyName = "payname";
            this.paynameDataGridViewTextBoxColumn.HeaderText = "payname";
            this.paynameDataGridViewTextBoxColumn.Name = "paynameDataGridViewTextBoxColumn";
            // 
            // yardidDataGridViewTextBoxColumn1
            // 
            this.yardidDataGridViewTextBoxColumn1.DataPropertyName = "yardid";
            this.yardidDataGridViewTextBoxColumn1.HeaderText = "yardid";
            this.yardidDataGridViewTextBoxColumn1.Name = "yardidDataGridViewTextBoxColumn1";
            // 
            // begintimeDataGridViewTextBoxColumn
            // 
            this.begintimeDataGridViewTextBoxColumn.DataPropertyName = "begintime";
            this.begintimeDataGridViewTextBoxColumn.HeaderText = "begintime";
            this.begintimeDataGridViewTextBoxColumn.Name = "begintimeDataGridViewTextBoxColumn";
            // 
            // overtimeDataGridViewTextBoxColumn
            // 
            this.overtimeDataGridViewTextBoxColumn.DataPropertyName = "overtime";
            this.overtimeDataGridViewTextBoxColumn.HeaderText = "overtime";
            this.overtimeDataGridViewTextBoxColumn.Name = "overtimeDataGridViewTextBoxColumn";
            // 
            // booktimeDataGridViewTextBoxColumn
            // 
            this.booktimeDataGridViewTextBoxColumn.DataPropertyName = "booktime";
            this.booktimeDataGridViewTextBoxColumn.HeaderText = "booktime";
            this.booktimeDataGridViewTextBoxColumn.Name = "booktimeDataGridViewTextBoxColumn";
            // 
            // realTimeDataGridViewTextBoxColumn
            // 
            this.realTimeDataGridViewTextBoxColumn.DataPropertyName = "realTime";
            this.realTimeDataGridViewTextBoxColumn.HeaderText = "realTime";
            this.realTimeDataGridViewTextBoxColumn.Name = "realTimeDataGridViewTextBoxColumn";
            // 
            // paymoneyDataGridViewTextBoxColumn
            // 
            this.paymoneyDataGridViewTextBoxColumn.DataPropertyName = "paymoney";
            this.paymoneyDataGridViewTextBoxColumn.HeaderText = "paymoney";
            this.paymoneyDataGridViewTextBoxColumn.Name = "paymoneyDataGridViewTextBoxColumn";
            // 
            // paytimeDataGridViewTextBoxColumn
            // 
            this.paytimeDataGridViewTextBoxColumn.DataPropertyName = "paytime";
            this.paytimeDataGridViewTextBoxColumn.HeaderText = "paytime";
            this.paytimeDataGridViewTextBoxColumn.Name = "paytimeDataGridViewTextBoxColumn";
            // 
            // pAYBindingSource
            // 
            this.pAYBindingSource.DataMember = "PAY";
            this.pAYBindingSource.DataSource = this.场馆预约系统DataSet16;
            // 
            // 场馆预约系统DataSet16
            // 
            this.场馆预约系统DataSet16.DataSetName = "场馆预约系统DataSet16";
            this.场馆预约系统DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(519, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(767, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(471, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "预订信息表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(471, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "支付信息表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(54, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "删除支付信息";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pAYBindingSource;
            this.comboBox1.DisplayMember = "payid";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 520);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "payid";
            // 
            // pAYTableAdapter
            // 
            this.pAYTableAdapter.ClearBeforeFill = true;
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
            // GLY_check_PAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 633);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GLY_check_PAY";
            this.Text = "查看支付情况";
            this.Load += new System.EventHandler(this.GLY_check_PAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private 场馆预约系统DataSet16 场馆预约系统DataSet16;
        private System.Windows.Forms.BindingSource pAYBindingSource;
        private 场馆预约系统DataSet16TableAdapters.PAYTableAdapter pAYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn payidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn begintimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytimeDataGridViewTextBoxColumn;
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
    }
}