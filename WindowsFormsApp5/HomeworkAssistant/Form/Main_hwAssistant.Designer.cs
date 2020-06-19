namespace HomeworkAssistant
{
    partial class Main_hwAssistant
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Class = new System.Windows.Forms.Button();
            this.btn_hmPublish = new System.Windows.Forms.Button();
            this.btn_hwCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Class
            // 
            this.btn_Class.Location = new System.Drawing.Point(266, 120);
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Size = new System.Drawing.Size(142, 66);
            this.btn_Class.TabIndex = 0;
            this.btn_Class.Text = "班级信息";
            this.btn_Class.UseVisualStyleBackColor = true;
            this.btn_Class.Click += new System.EventHandler(this.btn_Class_Click);
            // 
            // btn_hmPublish
            // 
            this.btn_hmPublish.Location = new System.Drawing.Point(266, 236);
            this.btn_hmPublish.Name = "btn_hmPublish";
            this.btn_hmPublish.Size = new System.Drawing.Size(142, 66);
            this.btn_hmPublish.TabIndex = 1;
            this.btn_hmPublish.Text = "发布作业";
            this.btn_hmPublish.UseVisualStyleBackColor = true;
            this.btn_hmPublish.Click += new System.EventHandler(this.btn_hmPublish_Click);
            // 
            // btn_hwCheck
            // 
            this.btn_hwCheck.Location = new System.Drawing.Point(266, 345);
            this.btn_hwCheck.Name = "btn_hwCheck";
            this.btn_hwCheck.Size = new System.Drawing.Size(142, 66);
            this.btn_hwCheck.TabIndex = 2;
            this.btn_hwCheck.Text = "查看已发布作业";
            this.btn_hwCheck.UseVisualStyleBackColor = true;
            this.btn_hwCheck.Click += new System.EventHandler(this.btn_hwCheck_Click);
            // 
            // Main_hwAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 511);
            this.Controls.Add(this.btn_hwCheck);
            this.Controls.Add(this.btn_hmPublish);
            this.Controls.Add(this.btn_Class);
            this.Name = "Main_hwAssistant";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Class;
        private System.Windows.Forms.Button btn_hmPublish;
        private System.Windows.Forms.Button btn_hwCheck;
    }
}

