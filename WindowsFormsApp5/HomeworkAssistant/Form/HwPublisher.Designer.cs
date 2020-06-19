namespace HomeworkAssistant
{
    partial class HwPublisher
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
            this.lbl_hwName = new System.Windows.Forms.Label();
            this.lbl_Formet = new System.Windows.Forms.Label();
            this.lbl_ddl = new System.Windows.Forms.Label();
            this.txt_hwName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbo_Format = new System.Windows.Forms.ComboBox();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hwName
            // 
            this.lbl_hwName.AutoSize = true;
            this.lbl_hwName.Location = new System.Drawing.Point(140, 91);
            this.lbl_hwName.Name = "lbl_hwName";
            this.lbl_hwName.Size = new System.Drawing.Size(52, 15);
            this.lbl_hwName.TabIndex = 0;
            this.lbl_hwName.Text = "作业名";
            // 
            // lbl_Formet
            // 
            this.lbl_Formet.AutoSize = true;
            this.lbl_Formet.Location = new System.Drawing.Point(487, 91);
            this.lbl_Formet.Name = "lbl_Formet";
            this.lbl_Formet.Size = new System.Drawing.Size(67, 15);
            this.lbl_Formet.TabIndex = 1;
            this.lbl_Formet.Text = "前缀格式";
            // 
            // lbl_ddl
            // 
            this.lbl_ddl.AutoSize = true;
            this.lbl_ddl.Location = new System.Drawing.Point(277, 193);
            this.lbl_ddl.Name = "lbl_ddl";
            this.lbl_ddl.Size = new System.Drawing.Size(31, 15);
            this.lbl_ddl.TabIndex = 2;
            this.lbl_ddl.Text = "DDL";
            // 
            // txt_hwName
            // 
            this.txt_hwName.Location = new System.Drawing.Point(212, 88);
            this.txt_hwName.Name = "txt_hwName";
            this.txt_hwName.Size = new System.Drawing.Size(200, 25);
            this.txt_hwName.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(338, 186);
            this.dateTimePicker.MinDate = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2020, 6, 16, 17, 10, 47, 0);
            // 
            // cbo_Format
            // 
            this.cbo_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Format.FormattingEnabled = true;
            this.cbo_Format.Items.AddRange(new object[] {
            "学号-姓名-第几次作业"});
            this.cbo_Format.Location = new System.Drawing.Point(575, 88);
            this.cbo_Format.Name = "cbo_Format";
            this.cbo_Format.Size = new System.Drawing.Size(121, 23);
            this.cbo_Format.TabIndex = 7;
            // 
            // btn_Publish
            // 
            this.btn_Publish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Publish.Location = new System.Drawing.Point(368, 270);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(75, 49);
            this.btn_Publish.TabIndex = 9;
            this.btn_Publish.Text = "发布";
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // HwPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Publish);
            this.Controls.Add(this.cbo_Format);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txt_hwName);
            this.Controls.Add(this.lbl_ddl);
            this.Controls.Add(this.lbl_Formet);
            this.Controls.Add(this.lbl_hwName);
            this.Name = "HwPublisher";
            this.Text = "HwPublisher";
            this.Load += new System.EventHandler(this.HwPublisher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hwName;
        private System.Windows.Forms.Label lbl_Formet;
        private System.Windows.Forms.Label lbl_ddl;
        private System.Windows.Forms.TextBox txt_hwName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbo_Format;
        private System.Windows.Forms.Button btn_Publish;
    }
}