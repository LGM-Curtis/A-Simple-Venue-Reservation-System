﻿namespace 预约系统2._0
{
    partial class YH_KanNote_GGL
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gGContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.场馆预约系统DataSet6 = new 预约系统2._0.场馆预约系统DataSet6();
            this.gGContentTableAdapter = new 预约系统2._0.场馆预约系统DataSet6TableAdapters.GGContentTableAdapter();
            this.noteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(223, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "公告栏";
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
            this.dataGridView1.DataSource = this.gGContentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(567, 409);
            this.dataGridView1.TabIndex = 3;
            // 
            // gGContentBindingSource
            // 
            this.gGContentBindingSource.DataMember = "GGContent";
            this.gGContentBindingSource.DataSource = this.场馆预约系统DataSet6;
            // 
            // 场馆预约系统DataSet6
            // 
            this.场馆预约系统DataSet6.DataSetName = "场馆预约系统DataSet6";
            this.场馆预约系统DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.informationDataGridViewTextBoxColumn.Width = 270;
            // 
            // noteTimeDataGridViewTextBoxColumn
            // 
            this.noteTimeDataGridViewTextBoxColumn.DataPropertyName = "NoteTime";
            this.noteTimeDataGridViewTextBoxColumn.HeaderText = "NoteTime";
            this.noteTimeDataGridViewTextBoxColumn.Name = "noteTimeDataGridViewTextBoxColumn";
            // 
            // YH_KanNote_GGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "YH_KanNote_GGL";
            this.Text = "查看公告栏";
            this.Load += new System.EventHandler(this.YH_KanNote_GGL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.场馆预约系统DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 场馆预约系统DataSet6 场馆预约系统DataSet6;
        private System.Windows.Forms.BindingSource gGContentBindingSource;
        private 场馆预约系统DataSet6TableAdapters.GGContentTableAdapter gGContentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteTimeDataGridViewTextBoxColumn;
    }
}