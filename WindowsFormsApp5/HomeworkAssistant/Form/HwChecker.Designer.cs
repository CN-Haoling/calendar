namespace HomeworkAssistant
{
    partial class HwChecker
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
            this.cbo_class = new System.Windows.Forms.ComboBox();
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.checkbox_ShowMissStu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MissAcount = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.stuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusHwDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskDetailbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDetailbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_class
            // 
            this.cbo_class.FormattingEnabled = true;
            this.cbo_class.Items.AddRange(new object[] {
            "全部",
            "已到期",
            "未到期"});
            this.cbo_class.Location = new System.Drawing.Point(61, 68);
            this.cbo_class.Name = "cbo_class";
            this.cbo_class.Size = new System.Drawing.Size(121, 23);
            this.cbo_class.TabIndex = 0;
            this.cbo_class.SelectedIndexChanged += new System.EventHandler(this.cbo_class_SelectedIndexChanged);
            // 
            // dgv_class
            // 
            this.dgv_class.AutoGenerateColumns = false;
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dDLDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn});
            this.dgv_class.DataSource = this.TaskbindingSource;
            this.dgv_class.Location = new System.Drawing.Point(61, 141);
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.ReadOnly = true;
            this.dgv_class.RowTemplate.Height = 27;
            this.dgv_class.Size = new System.Drawing.Size(342, 256);
            this.dgv_class.TabIndex = 1;
            this.dgv_class.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_class_CellClick);
            // 
            // dgv_student
            // 
            this.dgv_student.AutoGenerateColumns = false;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.statusHwDataGridViewCheckBoxColumn});
            this.dgv_student.DataSource = this.TaskDetailbindingSource;
            this.dgv_student.Location = new System.Drawing.Point(454, 141);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.ReadOnly = true;
            this.dgv_student.RowTemplate.Height = 27;
            this.dgv_student.Size = new System.Drawing.Size(285, 256);
            this.dgv_student.TabIndex = 2;
            // 
            // checkbox_ShowMissStu
            // 
            this.checkbox_ShowMissStu.AutoSize = true;
            this.checkbox_ShowMissStu.Location = new System.Drawing.Point(454, 72);
            this.checkbox_ShowMissStu.Name = "checkbox_ShowMissStu";
            this.checkbox_ShowMissStu.Size = new System.Drawing.Size(134, 19);
            this.checkbox_ShowMissStu.TabIndex = 3;
            this.checkbox_ShowMissStu.Text = "仅显示未交同学";
            this.checkbox_ShowMissStu.UseVisualStyleBackColor = true;
            this.checkbox_ShowMissStu.CheckedChanged += new System.EventHandler(this.checkbox_ShowMissStu_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "未交人数 ：";
            // 
            // lbl_MissAcount
            // 
            this.lbl_MissAcount.AutoSize = true;
            this.lbl_MissAcount.Location = new System.Drawing.Point(547, 422);
            this.lbl_MissAcount.Name = "lbl_MissAcount";
            this.lbl_MissAcount.Size = new System.Drawing.Size(31, 15);
            this.lbl_MissAcount.TabIndex = 5;
            this.lbl_MissAcount.Text = "( )";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(61, 413);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(86, 33);
            this.btn_download.TabIndex = 6;
            this.btn_download.Text = "下载作业";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(174, 413);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(88, 33);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // stuIdDataGridViewTextBoxColumn
            // 
            this.stuIdDataGridViewTextBoxColumn.DataPropertyName = "StuId";
            this.stuIdDataGridViewTextBoxColumn.HeaderText = "学号";
            this.stuIdDataGridViewTextBoxColumn.Name = "stuIdDataGridViewTextBoxColumn";
            this.stuIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusHwDataGridViewCheckBoxColumn
            // 
            this.statusHwDataGridViewCheckBoxColumn.DataPropertyName = "Status_Hw";
            this.statusHwDataGridViewCheckBoxColumn.HeaderText = "是否提交作业";
            this.statusHwDataGridViewCheckBoxColumn.Name = "statusHwDataGridViewCheckBoxColumn";
            this.statusHwDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusHwDataGridViewCheckBoxColumn.Width = 120;
            // 
            // TaskDetailbindingSource
            // 
            this.TaskDetailbindingSource.DataSource = typeof(HomeworkAssistant.TaskDetail);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDLDataGridViewTextBoxColumn
            // 
            this.dDLDataGridViewTextBoxColumn.DataPropertyName = "DDL";
            this.dDLDataGridViewTextBoxColumn.HeaderText = "DDL";
            this.dDLDataGridViewTextBoxColumn.Name = "dDLDataGridViewTextBoxColumn";
            this.dDLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TaskbindingSource
            // 
            this.TaskbindingSource.DataSource = typeof(HomeworkAssistant.Tasks);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(286, 414);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(91, 32);
            this.btn_Del.TabIndex = 8;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // HwChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 463);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.lbl_MissAcount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_ShowMissStu);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.dgv_class);
            this.Controls.Add(this.cbo_class);
            this.Name = "HwChecker";
            this.Text = "HwChecker";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDetailbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_class;
        private System.Windows.Forms.DataGridView dgv_class;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.CheckBox checkbox_ShowMissStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource TaskbindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MissAcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusHwDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource TaskDetailbindingSource;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Del;
    }
}