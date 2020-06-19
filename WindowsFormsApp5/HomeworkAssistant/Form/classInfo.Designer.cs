namespace HomeworkAssistant
{
    partial class classInfo
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
            this.btn_addstu = new System.Windows.Forms.Button();
            this.btn_delstu = new System.Windows.Forms.Button();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.stubindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stubindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addstu
            // 
            this.btn_addstu.Location = new System.Drawing.Point(146, 79);
            this.btn_addstu.Name = "btn_addstu";
            this.btn_addstu.Size = new System.Drawing.Size(75, 23);
            this.btn_addstu.TabIndex = 1;
            this.btn_addstu.Text = "添加学生";
            this.btn_addstu.UseVisualStyleBackColor = true;
            this.btn_addstu.Click += new System.EventHandler(this.btn_addstu_Click);
            // 
            // btn_delstu
            // 
            this.btn_delstu.Location = new System.Drawing.Point(298, 79);
            this.btn_delstu.Name = "btn_delstu";
            this.btn_delstu.Size = new System.Drawing.Size(75, 23);
            this.btn_delstu.TabIndex = 3;
            this.btn_delstu.Text = "删除学生";
            this.btn_delstu.UseVisualStyleBackColor = true;
            this.btn_delstu.Click += new System.EventHandler(this.btn_delstu_Click);
            // 
            // dgv_student
            // 
            this.dgv_student.AutoGenerateColumns = false;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgv_student.DataSource = this.stubindingSource;
            this.dgv_student.Location = new System.Drawing.Point(94, 137);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowTemplate.Height = 27;
            this.dgv_student.Size = new System.Drawing.Size(335, 291);
            this.dgv_student.TabIndex = 5;
            // 
            // stubindingSource
            // 
            this.stubindingSource.DataSource = typeof(HomeworkAssistant.Student);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // classInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 471);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.btn_delstu);
            this.Controls.Add(this.btn_addstu);
            this.Name = "classInfo";
            this.Text = "classInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stubindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addstu;
        private System.Windows.Forms.Button btn_delstu;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.BindingSource stubindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}