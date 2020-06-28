namespace WindowsFormsApp5
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("未读邮件");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("所有邮件");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("已删除");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("发件箱");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("我的邮件", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nowMailUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.nowMailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nowMailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.subjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nowMailUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nowMailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nowMailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "未读邮件";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "所有邮件";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 25);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "主题",
            "发件人"});
            this.comboBox1.Location = new System.Drawing.Point(453, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 24);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "节点1";
            treeNode6.Text = "未读邮件";
            treeNode7.Name = "节点3";
            treeNode7.Text = "所有邮件";
            treeNode8.Name = "节点0";
            treeNode8.Text = "已删除";
            treeNode9.Name = "节点1";
            treeNode9.Text = "发件箱";
            treeNode10.Name = "节点0";
            treeNode10.Text = "我的邮件";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(122, 190);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.subjectDataGridViewTextBoxColumn1,
            this.fromDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.Column2});
            this.dataGridView2.DataSource = this.nowMailUSBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(140, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(866, 343);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = "选中";
            this.select.Name = "select";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "打开";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Text = "查看";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // nowMailUSBindingSource
            // 
            this.nowMailUSBindingSource.DataMember = "NowMailUS";
            this.nowMailUSBindingSource.DataSource = this.mCBindingSource1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nowMailsBindingSource
            // 
            this.nowMailsBindingSource.DataMember = "NowMails";
            this.nowMailsBindingSource.DataSource = this.mCBindingSource;
            // 
            // nowMailsBindingSource1
            // 
            this.nowMailsBindingSource1.DataMember = "NowMails";
            this.nowMailsBindingSource1.DataSource = this.mCBindingSource;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "删除选中邮件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(314, 393);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 32);
            this.button6.TabIndex = 10;
            this.button6.Text = "选中邮件标星";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(437, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 32);
            this.button7.TabIndex = 11;
            this.button7.Text = "设置邮件未读";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(560, 393);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 32);
            this.button8.TabIndex = 12;
            this.button8.Text = "取消标星";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(683, 393);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 32);
            this.button9.TabIndex = 13;
            this.button9.Text = "设为已读";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(29, 254);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 56);
            this.button10.TabIndex = 14;
            this.button10.Text = "作业小助手";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // subjectDataGridViewTextBoxColumn1
            // 
            this.subjectDataGridViewTextBoxColumn1.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn1.HeaderText = "主题";
            this.subjectDataGridViewTextBoxColumn1.Name = "subjectDataGridViewTextBoxColumn1";
            // 
            // fromDataGridViewTextBoxColumn1
            // 
            this.fromDataGridViewTextBoxColumn1.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn1.HeaderText = "发件人";
            this.fromDataGridViewTextBoxColumn1.Name = "fromDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "邮件ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // mCBindingSource1
            // 
            this.mCBindingSource1.DataSource = typeof(MailControl.MC);
            // 
            // mCBindingSource
            // 
            this.mCBindingSource.DataSource = typeof(MailControl.MC);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MailControl.User);
            // 
            // mailBoxBindingSource
            // 
            this.mailBoxBindingSource.DataSource = typeof(MailControl.MailBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nowMailUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nowMailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nowMailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mCBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource mailBoxBindingSource;
        private System.Windows.Forms.BindingSource nowMailsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource nowMailsBindingSource1;
        private System.Windows.Forms.BindingSource nowMailUSBindingSource;
        private System.Windows.Forms.BindingSource mCBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}