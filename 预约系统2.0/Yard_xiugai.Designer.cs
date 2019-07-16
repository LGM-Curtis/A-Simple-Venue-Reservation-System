namespace 预约系统2._0
{
    partial class Yard_xiugai
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textbox4 = new System.Windows.Forms.TextBox();
            this.textbox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yardAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet10 = new 预约系统2._0.场馆预约系统DataSet10();
            this.yardAddressTableAdapter = new 预约系统2._0.场馆预约系统DataSet10TableAdapters.YardAddressTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.yardNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet11 = new 预约系统2._0.场馆预约系统DataSet11();
            this.yardNameTableAdapter = new 预约系统2._0.场馆预约系统DataSet11TableAdapters.YardNameTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.场馆预约系统DataSet14 = new 预约系统2._0.场馆预约系统DataSet14();
            this.yardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yardTableAdapter = new 预约系统2._0.场馆预约系统DataSet14TableAdapters.YardTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(397, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(857, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(855, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(304, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "场地编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(287, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "场地名称编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(287, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "场地地址编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(304, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "开放时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(304, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "场地单价";
            // 
            // textbox1
            // 
            this.textbox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox1.Location = new System.Drawing.Point(397, 39);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(174, 26);
            this.textbox1.TabIndex = 10;
            // 
            // textbox2
            // 
            this.textbox2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox2.Location = new System.Drawing.Point(397, 81);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(174, 26);
            this.textbox2.TabIndex = 11;
            // 
            // textbox3
            // 
            this.textbox3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox3.Location = new System.Drawing.Point(397, 123);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(174, 26);
            this.textbox3.TabIndex = 12;
            // 
            // textbox4
            // 
            this.textbox4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox4.Location = new System.Drawing.Point(397, 165);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(174, 26);
            this.textbox4.TabIndex = 13;
            // 
            // textbox5
            // 
            this.textbox5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox5.Location = new System.Drawing.Point(397, 204);
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(174, 26);
            this.textbox5.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardAddressIDDataGridViewTextBoxColumn,
            this.yardAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yardAddressBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(243, 134);
            this.dataGridView1.TabIndex = 16;
            // 
            // yardAddressIDDataGridViewTextBoxColumn
            // 
            this.yardAddressIDDataGridViewTextBoxColumn.DataPropertyName = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn.HeaderText = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn.Name = "yardAddressIDDataGridViewTextBoxColumn";
            this.yardAddressIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // yardAddressDataGridViewTextBoxColumn
            // 
            this.yardAddressDataGridViewTextBoxColumn.DataPropertyName = "YardAddress";
            this.yardAddressDataGridViewTextBoxColumn.HeaderText = "YardAddress";
            this.yardAddressDataGridViewTextBoxColumn.Name = "yardAddressDataGridViewTextBoxColumn";
            this.yardAddressDataGridViewTextBoxColumn.Width = 120;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardNameIDDataGridViewTextBoxColumn,
            this.yardNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.yardNameBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(243, 150);
            this.dataGridView2.TabIndex = 17;
            // 
            // yardNameIDDataGridViewTextBoxColumn
            // 
            this.yardNameIDDataGridViewTextBoxColumn.DataPropertyName = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn.HeaderText = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn.Name = "yardNameIDDataGridViewTextBoxColumn";
            this.yardNameIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // yardNameDataGridViewTextBoxColumn
            // 
            this.yardNameDataGridViewTextBoxColumn.DataPropertyName = "YardName";
            this.yardNameDataGridViewTextBoxColumn.HeaderText = "YardName";
            this.yardNameDataGridViewTextBoxColumn.Name = "yardNameDataGridViewTextBoxColumn";
            this.yardNameDataGridViewTextBoxColumn.Width = 140;
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
            // yardNameTableAdapter
            // 
            this.yardNameTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(620, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "场地编号";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.yardBindingSource;
            this.comboBox1.DisplayMember = "YardID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(698, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "YardID";
            // 
            // 场馆预约系统DataSet14
            // 
            this.场馆预约系统DataSet14.DataSetName = "场馆预约系统DataSet14";
            this.场馆预约系统DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardBindingSource
            // 
            this.yardBindingSource.DataMember = "Yard";
            this.yardBindingSource.DataSource = this.场馆预约系统DataSet14;
            // 
            // yardTableAdapter
            // 
            this.yardTableAdapter.ClearBeforeFill = true;
            // 
            // Yard_xiugai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 319);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Yard_xiugai";
            this.Text = "修改场地信息";
            this.Load += new System.EventHandler(this.Yard_xiugai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.TextBox textbox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 场馆预约系统DataSet10 场馆预约系统DataSet10;
        private System.Windows.Forms.BindingSource yardAddressBindingSource;
        private 场馆预约系统DataSet10TableAdapters.YardAddressTableAdapter yardAddressTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private 场馆预约系统DataSet11 场馆预约系统DataSet11;
        private System.Windows.Forms.BindingSource yardNameBindingSource;
        private 场馆预约系统DataSet11TableAdapters.YardNameTableAdapter yardNameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private 场馆预约系统DataSet14 场馆预约系统DataSet14;
        private System.Windows.Forms.BindingSource yardBindingSource;
        private 场馆预约系统DataSet14TableAdapters.YardTableAdapter yardTableAdapter;
    }
}