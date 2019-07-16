namespace 预约系统2._0
{
    partial class Note_chakan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.场馆预约系统DataSet4 = new 预约系统2._0.场馆预约系统DataSet4();
            this.systemContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemContentTableAdapter = new 预约系统2._0.场馆预约系统DataSet4TableAdapters.SystemContentTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.场馆预约系统DataSet5 = new 预约系统2._0.场馆预约系统DataSet5();
            this.yardContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yardContentTableAdapter = new 预约系统2._0.场馆预约系统DataSet5TableAdapters.YardContentTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.场馆预约系统DataSet6 = new 预约系统2._0.场馆预约系统DataSet6();
            this.gGContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gGContentTableAdapter = new 预约系统2._0.场馆预约系统DataSet6TableAdapters.GGContentTableAdapter();
            this.noteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGContentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(306, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.informationDataGridViewTextBoxColumn,
            this.noteTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.systemContentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "系统通知";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "场地通知";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "公告栏";
            // 
            // 场馆预约系统DataSet4
            // 
            this.场馆预约系统DataSet4.DataSetName = "场馆预约系统DataSet4";
            this.场馆预约系统DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemContentBindingSource
            // 
            this.systemContentBindingSource.DataMember = "SystemContent";
            this.systemContentBindingSource.DataSource = this.场馆预约系统DataSet4;
            // 
            // systemContentTableAdapter
            // 
            this.systemContentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.yardContentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(747, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // 场馆预约系统DataSet5
            // 
            this.场馆预约系统DataSet5.DataSetName = "场馆预约系统DataSet5";
            this.场馆预约系统DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardContentBindingSource
            // 
            this.yardContentBindingSource.DataMember = "YardContent";
            this.yardContentBindingSource.DataSource = this.场馆预约系统DataSet5;
            // 
            // yardContentTableAdapter
            // 
            this.yardContentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView3.DataSource = this.gGContentBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(-1, 386);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(747, 150);
            this.dataGridView3.TabIndex = 10;
            // 
            // 场馆预约系统DataSet6
            // 
            this.场馆预约系统DataSet6.DataSetName = "场馆预约系统DataSet6";
            this.场馆预约系统DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gGContentBindingSource
            // 
            this.gGContentBindingSource.DataMember = "GGContent";
            this.gGContentBindingSource.DataSource = this.场馆预约系统DataSet6;
            // 
            // gGContentTableAdapter
            // 
            this.gGContentTableAdapter.ClearBeforeFill = true;
            // 
            // noteIDDataGridViewTextBoxColumn
            // 
            this.noteIDDataGridViewTextBoxColumn.DataPropertyName = "NoteID";
            this.noteIDDataGridViewTextBoxColumn.HeaderText = "NoteID";
            this.noteIDDataGridViewTextBoxColumn.Name = "noteIDDataGridViewTextBoxColumn";
            this.noteIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "Information";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            this.informationDataGridViewTextBoxColumn.Width = 450;
            // 
            // noteTimeDataGridViewTextBoxColumn
            // 
            this.noteTimeDataGridViewTextBoxColumn.DataPropertyName = "NoteTime";
            this.noteTimeDataGridViewTextBoxColumn.HeaderText = "NoteTime";
            this.noteTimeDataGridViewTextBoxColumn.Name = "noteTimeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoteID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Information";
            this.dataGridViewTextBoxColumn3.HeaderText = "Information";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 450;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoteTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoteTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NoteID";
            this.dataGridViewTextBoxColumn5.HeaderText = "NoteID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Information";
            this.dataGridViewTextBoxColumn7.HeaderText = "Information";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 450;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NoteTime";
            this.dataGridViewTextBoxColumn8.HeaderText = "NoteTime";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Note_chakan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 587);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Note_chakan";
            this.Text = "查看通知";
            this.Load += new System.EventHandler(this.Note_chakan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGContentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private 场馆预约系统DataSet4 场馆预约系统DataSet4;
        private System.Windows.Forms.BindingSource systemContentBindingSource;
        private 场馆预约系统DataSet4TableAdapters.SystemContentTableAdapter systemContentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private 场馆预约系统DataSet5 场馆预约系统DataSet5;
        private System.Windows.Forms.BindingSource yardContentBindingSource;
        private 场馆预约系统DataSet5TableAdapters.YardContentTableAdapter yardContentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private 场馆预约系统DataSet6 场馆预约系统DataSet6;
        private System.Windows.Forms.BindingSource gGContentBindingSource;
        private 场馆预约系统DataSet6TableAdapters.GGContentTableAdapter gGContentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}