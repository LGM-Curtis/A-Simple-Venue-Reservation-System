namespace 预约系统2._0
{
    partial class Yard_chakan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.场馆预约系统DataSet13 = new 预约系统2._0.场馆预约系统DataSet13();
            this.yardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yardTableAdapter1 = new 预约系统2._0.场馆预约系统DataSet13TableAdapters.YardTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(229, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardIDDataGridViewTextBoxColumn,
            this.yardNameIDDataGridViewTextBoxColumn,
            this.yardAddressIDDataGridViewTextBoxColumn,
            this.openTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yardBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(666, 427);
            this.dataGridView1.TabIndex = 2;
            // 
            // yardIDDataGridViewTextBoxColumn
            // 
            this.yardIDDataGridViewTextBoxColumn.DataPropertyName = "YardID";
            this.yardIDDataGridViewTextBoxColumn.HeaderText = "YardID";
            this.yardIDDataGridViewTextBoxColumn.Name = "yardIDDataGridViewTextBoxColumn";
            // 
            // yardNameIDDataGridViewTextBoxColumn
            // 
            this.yardNameIDDataGridViewTextBoxColumn.DataPropertyName = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn.HeaderText = "YardNameID";
            this.yardNameIDDataGridViewTextBoxColumn.Name = "yardNameIDDataGridViewTextBoxColumn";
            // 
            // yardAddressIDDataGridViewTextBoxColumn
            // 
            this.yardAddressIDDataGridViewTextBoxColumn.DataPropertyName = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn.HeaderText = "YardAddressID";
            this.yardAddressIDDataGridViewTextBoxColumn.Name = "yardAddressIDDataGridViewTextBoxColumn";
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
            // 
            // 场馆预约系统DataSet13
            // 
            this.场馆预约系统DataSet13.DataSetName = "场馆预约系统DataSet13";
            this.场馆预约系统DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardBindingSource1
            // 
            this.yardBindingSource1.DataMember = "Yard";
            this.yardBindingSource1.DataSource = this.场馆预约系统DataSet13;
            // 
            // yardTableAdapter1
            // 
            this.yardTableAdapter1.ClearBeforeFill = true;
            // 
            // Yard_chakan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Yard_chakan";
            this.Text = "查看场地";
            this.Load += new System.EventHandler(this.Yard_chazhao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private 场馆预约系统DataSet13 场馆预约系统DataSet13;
        private System.Windows.Forms.BindingSource yardBindingSource1;
        private 场馆预约系统DataSet13TableAdapters.YardTableAdapter yardTableAdapter1;
    }
}