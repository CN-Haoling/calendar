namespace HomeworkAssistant
{
    partial class StudentInfo
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(159, 89);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(37, 15);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "学号";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(159, 180);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(37, 15);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "姓名";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(159, 269);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(67, 15);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "邮箱地址";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(292, 86);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 25);
            this.txt_Id.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(292, 177);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 25);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(292, 266);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 25);
            this.txt_email.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(238, 337);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_save;
    }
}