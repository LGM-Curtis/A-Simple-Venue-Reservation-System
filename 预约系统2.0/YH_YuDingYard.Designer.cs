namespace 预约系统2._0
{
    partial class YH_YuDingYard
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet13 = new 预约系统2._0.场馆预约系统DataSet13();
            this.yardNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet11 = new 预约系统2._0.场馆预约系统DataSet11();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yardNameTableAdapter = new 预约系统2._0.场馆预约系统DataSet11TableAdapters.YardNameTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.yardTableAdapter = new 预约系统2._0.场馆预约系统DataSet13TableAdapters.YardTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yardNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.yardAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet10 = new 预约系统2._0.场馆预约系统DataSet10();
            this.yardAddressTableAdapter = new 预约系统2._0.场馆预约系统DataSet10TableAdapters.YardAddressTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.yardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardNameIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardAddressIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(295, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(363, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "预订";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(97, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "开始时间";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.yardBindingSource;
            this.comboBox1.DisplayMember = "YardID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "YardID";
            // 
            // yardBindingSource
            // 
            this.yardBindingSource.DataMember = "Yard";
            this.yardBindingSource.DataSource = this.场馆预约系统DataSet13;
            // 
            // 场馆预约系统DataSet13
            // 
            this.场馆预约系统DataSet13.DataSetName = "场馆预约系统DataSet13";
            this.场馆预约系统DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardNameBindingSource
            // 
            this.yardNameBindingSource.DataMember = "YardName";
            this.yardNameBindingSource.DataSource = this.场馆预约系统DataSet11;
            // 
            // 场馆预约系统DataSet11
            // 
            this.场馆预约系统DataSet11.DataSetName = "场馆预约系统DataSet11";
            this.场馆预约系统DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(97, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "结束时间";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.comboBox2.Location = new System.Drawing.Point(199, 288);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(97, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(95, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "场地名称";
            // 
            // yardNameTableAdapter
            // 
            this.yardNameTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30"});
            this.comboBox3.Location = new System.Drawing.Point(199, 329);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(410, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "姓名";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(480, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 29);
            this.textBox2.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(410, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "电话";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(480, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 29);
            this.textBox3.TabIndex = 38;
            // 
            // yardTableAdapter
            // 
            this.yardTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardNameIDDataGridViewTextBoxColumn,
            this.yardNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yardNameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(307, 166);
            this.dataGridView1.TabIndex = 39;
            // 
            // yardNameIDDataGridViewTextBoxColumn
            // 
            this.yardNameIDDataGridViewTextBoxColumn.DataPropertyName = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn.HeaderText = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn.Name = "yardNameIDDataGridViewTextBoxColumn";
            this.yardNameIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // yardNameDataGridViewTextBoxColumn
            // 
            this.yardNameDataGridViewTextBoxColumn.DataPropertyName = "YardName";
            this.yardNameDataGridViewTextBoxColumn.HeaderText = "YardName";
            this.yardNameDataGridViewTextBoxColumn.Name = "yardNameDataGridViewTextBoxColumn";
            this.yardNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardAddressIDDataGridViewTextBoxColumn,
            this.yardAddressDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.yardAddressBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(363, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(358, 166);
            this.dataGridView2.TabIndex = 40;
            // 
            // yardAddressIDDataGridViewTextBoxColumn
            // 
            this.yardAddressIDDataGridViewTextBoxColumn.DataPropertyName = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn.HeaderText = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn.Name = "yardAddressIDDataGridViewTextBoxColumn";
            this.yardAddressIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // yardAddressDataGridViewTextBoxColumn
            // 
            this.yardAddressDataGridViewTextBoxColumn.DataPropertyName = "YardAddress";
            this.yardAddressDataGridViewTextBoxColumn.HeaderText = "YardAddress";
            this.yardAddressDataGridViewTextBoxColumn.Name = "yardAddressDataGridViewTextBoxColumn";
            this.yardAddressDataGridViewTextBoxColumn.Width = 140;
            // 
            // yardAddressBindingSource
            // 
            this.yardAddressBindingSource.DataMember = "YardAddress";
            this.yardAddressBindingSource.DataSource = this.场馆预约系统DataSet10;
            // 
            // 场馆预约系统DataSet10
            // 
            this.场馆预约系统DataSet10.DataSetName = "场馆预约系统DataSet10";
            this.场馆预约系统DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardAddressTableAdapter
            // 
            this.yardAddressTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "场地名称表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(496, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "场地地址表";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardIDDataGridViewTextBoxColumn,
            this.yardNameIDDataGridViewTextBoxColumn1,
            this.yardAddressIDDataGridViewTextBoxColumn1,
            this.openTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.yardBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(744, 41);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(573, 465);
            this.dataGridView3.TabIndex = 43;
            // 
            // yardIDDataGridViewTextBoxColumn
            // 
            this.yardIDDataGridViewTextBoxColumn.DataPropertyName = "YardID";
            this.yardIDDataGridViewTextBoxColumn.HeaderText = "YardID";
            this.yardIDDataGridViewTextBoxColumn.Name = "yardIDDataGridViewTextBoxColumn";
            this.yardIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // yardNameIDDataGridViewTextBoxColumn1
            // 
            this.yardNameIDDataGridViewTextBoxColumn1.DataPropertyName = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn1.HeaderText = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn1.Name = "yardNameIDDataGridViewTextBoxColumn1";
            // 
            // yardAddressIDDataGridViewTextBoxColumn1
            // 
            this.yardAddressIDDataGridViewTextBoxColumn1.DataPropertyName = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn1.HeaderText = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn1.Name = "yardAddressIDDataGridViewTextBoxColumn1";
            this.yardAddressIDDataGridViewTextBoxColumn1.Width = 140;
            // 
            // openTimeDataGridViewTextBoxColumn
            // 
            this.openTimeDataGridViewTextBoxColumn.DataPropertyName = "OpenTime";
            this.openTimeDataGridViewTextBoxColumn.HeaderText = "OpenTime";
            this.openTimeDataGridViewTextBoxColumn.Name = "openTimeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(987, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "场地信息表";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 361);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Value = new System.DateTime(2019, 3, 10, 0, 0, 0, 0);
            // 
            // YH_YuDingYard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 518);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "YH_YuDingYard";
            this.Text = "查看场地信息及预约";
            this.Load += new System.EventHandler(this.YH_YuDingYard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private 场馆预约系统DataSet11 场馆预约系统DataSet11;
        private System.Windows.Forms.BindingSource yardNameBindingSource;
        private 场馆预约系统DataSet11TableAdapters.YardNameTableAdapter yardNameTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private 场馆预约系统DataSet13 场馆预约系统DataSet13;
        private System.Windows.Forms.BindingSource yardBindingSource;
        private 场馆预约系统DataSet13TableAdapters.YardTableAdapter yardTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private 场馆预约系统DataSet10 场馆预约系统DataSet10;
        private System.Windows.Forms.BindingSource yardAddressBindingSource;
        private 场馆预约系统DataSet10TableAdapters.YardAddressTableAdapter yardAddressTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardNameIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardAddressIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn openTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
    }
}