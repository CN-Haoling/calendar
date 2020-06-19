using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailControl;
using HomeworkAssistant;
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        User User;
        public Form1(User a)
        {
            InitializeComponent();
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.BackgroundColor = Color.White;
            //dataGridView2.UseColumnTextForButtonValue = true;
            User = a;
            mailcontrol = new MC(User);
            mailcontrol.init(0);
            mailcontrol.init(1);
            mailcontrol.init(2);
            mailcontrol.init(3);

        }
        MC mailcontrol;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            mailcontrol.PullMessage(0);
            
            List<MailMessage> result = mailcontrol.Mailbox.usMessages.ToList();
            nowMailsBindingSource.DataSource = result;
            mailcontrol.showmessages(0);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MailMessage msg = nowMailsBindingSource.Current as MailMessage;
            
            FormDetail formd = new FormDetail(msg,mailcontrol);
            formd.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            mailcontrol.PullMessage(1);

            List<MailMessage> result = mailcontrol.Mailbox.Messages.ToList();
            nowMailsBindingSource.DataSource = result;
            mailcontrol.showmessages(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            string a = textBox1.Text;
            List<Mail> dest=new List<Mail>();
            switch (treeView1.SelectedNode.Text) {
                case "未读邮件":
                    dest = mailcontrol.NowMailUS;
                    break;
                case "所有邮件":
                    dest = mailcontrol.NowMailALL;
                    break;
                case "发件箱":
                    dest = mailcontrol.SENTMail;
                    break;
                case "已删除":
                    dest = mailcontrol.TRASHMail;
                    break;

            }
            List<Mail> answer;
            string action = comboBox1.Text;
            if (action != "") {
                switch (action) {
                    case "发件人":
                        answer = mailcontrol.QueryBySender(a,dest);
                        nowMailUSBindingSource.DataSource = answer;
                        break;
                    case "主题":
                        answer = mailcontrol.QueryBySub(a,dest);
                        nowMailUSBindingSource.DataSource = answer;
                        break;
                }
               


            }
            else { MessageBox.Show("请选择搜索关键字"); }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string a = treeView1.SelectedNode.Text;
            List<MailMessage> result;
            switch (a) {
                case "未读邮件":
                    Console.WriteLine("***");                    
                    nowMailUSBindingSource.DataSource = mailcontrol.NowMailUS;
                    break;
                case "所有邮件":
                    nowMailUSBindingSource.DataSource = mailcontrol.NowMailALL;
                    mailcontrol.showmessages(1);
                    break;
                case "已删除":
                    nowMailUSBindingSource.DataSource = mailcontrol.TRASHMail;
                    break;

                case "发件箱":
                    nowMailUSBindingSource.DataSource = mailcontrol.SENTMail;
                    break;
                default:
                    break;


            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Column2" && e.RowIndex >= 0)
            {
                string BOX = "INBOX"; ;
                switch (treeView1.SelectedNode.Text) {
                    case "未读邮件":
                        BOX = "INBOX";
                        break;
                    case "所有邮件":
                        BOX = "INBOX";
                        break;
                    case "已删除":
                        BOX = "Deleted Messages";
                        break;

                    case "发件箱":
                        BOX = "sent messages";
                        break;
                }
                //说明点击的列是DataGridViewButtonColumn列
                DataGridViewColumn column = dataGridView2.Columns[e.ColumnIndex];
                mailcontrol.reconnect();
                Mail now = nowMailUSBindingSource.Current as Mail;
                string a = treeView1.SelectedNode.Text;
                Console.WriteLine(a);
                MailMessage msg = mailcontrol.PullMessage(now.Id, BOX);
                FormDetail formd = new FormDetail(msg, mailcontrol);
                formd.ShowDialog();


            }           


            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != null)
            {
                MessageBox.Show("正在获取最新邮件");
                switch (treeView1.SelectedNode.Text)
                {
                    case "未读邮件":
                        
                        mailcontrol.reconnect();
                        mailcontrol.PullMessage(0);
                        nowMailUSBindingSource.DataSource = mailcontrol.NowMailALL;
                        nowMailUSBindingSource.DataSource = mailcontrol.NowMailUS;
                        MessageBox.Show("获取成功");
                        break;
                    case "所有邮件":
                        mailcontrol.reconnect();
                        mailcontrol.PullMessage(1);
                        nowMailUSBindingSource.DataSource = mailcontrol.NowMailUS;
                        nowMailUSBindingSource.DataSource = mailcontrol.NowMailALL;
                        MessageBox.Show("获取成功");
                        break;
                    case "发件箱":
                        mailcontrol.reconnect();
                        mailcontrol.PullMessage(2);
                        nowMailUSBindingSource.DataSource = mailcontrol.NowMailALL;
                        nowMailUSBindingSource.DataSource = mailcontrol.SENTMail;
                        MessageBox.Show("获取成功");
                        break;
                    case "已删除":
                        mailcontrol.reconnect();
                        mailcontrol.PullMessage(3);
                        nowMailUSBindingSource.DataSource = mailcontrol.NowMailALL;
                        nowMailUSBindingSource.DataSource = mailcontrol.TRASHMail;
                        MessageBox.Show("获取成功");
                        break;
                }
            }

        }
        public List<uint> getSelect() {
            List<uint> uidToUse = new List<uint>();
            int count = Convert.ToInt32(dataGridView2.Rows.Count.ToString());
            for (int i = 0; i < count; i++)
            {
                //如果DataGridView是可编辑的，将数据提交，否则处于编辑状态的行无法取到
                //dataGridView2.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView2.Rows[i].Cells["select"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)    //查找被选择的数据行
                {
                    //从 DATAGRIDVIEW 中获取数据项
                    string z_zcode = dataGridView2.Rows[i].Cells[4].Value.ToString().Trim();
                    uint ID = Convert.ToUInt16(z_zcode);
                    uidToUse.Add(ID);
                }
            }
            return uidToUse;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Mail> now = new List<Mail>();
            int action = 1;
            switch (treeView1.SelectedNode.Text)
            {
                case "未读邮件":
                    now = mailcontrol.NowMailUS;
                    action = 1;
                    break;
                case "所有邮件":
                    now = mailcontrol.NowMailALL ;
                    action = 1;
                    break;
                case "已删除":
                    now = mailcontrol.TRASHMail;
                    action = 4;
                    break;

                case "发件箱":
                    now = mailcontrol.SENTMail;
                    action = 2;
                    break;
            }
            var a =  getSelect();
            mailcontrol.delete(a,now,action);
            //nowMailUSBindingSource.DataSource = now;
            //dataGridView2.DataSource = nowMailUSBindingSource.DataSource;
            nowMailUSBindingSource.DataSource = mailcontrol.SENTMail;
            switch (treeView1.SelectedNode.Text)
            {
                case "未读邮件":
                    nowMailUSBindingSource.DataSource = mailcontrol.NowMailUS;
                    action = 1;
                    break;
                case "所有邮件":
                    nowMailUSBindingSource.DataSource = mailcontrol.NowMailALL;
                    action = 1;
                    break;
                case "已删除":
                    nowMailUSBindingSource.DataSource = mailcontrol.TRASHMail;
                    action = 4;
                    break;

                case "发件箱":
                    nowMailUSBindingSource.DataSource = mailcontrol.SENTMail;
                    action = 2;
                    break;
            }
            dataGridView2.Refresh();
            //nowMailUSBindingSource.DataSource = now;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var a = getSelect();
            mailcontrol.markStar(a);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var a = getSelect();
            mailcontrol.markUnSeen(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var a = getSelect();
            mailcontrol.UnmarkStar(a);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var a = getSelect();
            mailcontrol.markSeen(a);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Main_hwAssistant form = new Main_hwAssistant(mailcontrol);
            form.Show();
        }
    }
}
