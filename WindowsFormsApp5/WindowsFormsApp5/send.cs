using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MailControl;

namespace WindowsFormsApp5
{
    public partial class send : Form
    {
        User usersend;
        public send(User user)
        {
            InitializeComponent();
            usersend = user;
            textBox4.Text = user.userAdd;
        }
        public send(string add,User user)
        {
            InitializeComponent();
            usersend = user;
            textBox4.Text = user.userAdd;
            textBox1.Text = add;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox6.Text = this.openFileDialog1.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "testXML.xml";
            System.Net.Mail.MailMessage myMail =
                new System.Net.Mail.MailMessage();

            MailMessage msg = new MailMessage();

            msg.Subject = this.textBox2.Text;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = this.textBox3.Text;
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            
            //msg.From = new MailAddress(this.textBox4.Text);
            msg.From = new MailAddress(usersend.userAdd);
            //可以添加判断text是否是邮箱格式

            //msg.To.Add(this.textBox1.Text);
            //msg.To.Add("1097506252@qq.com");
            msg.To.Add(textBox1.Text);
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.qq.com";
            //client.Port  好像QQ邮箱不需要端口

            NetworkCredential credential = new NetworkCredential();
            //credential.UserName = this.textBox4.Text;
            credential.UserName = usersend.userAdd;
            //credential.Password = this.textBox5.Text;
            credential.Password = usersend.userCode;
            client.Credentials = credential;
            if (this.textBox6.Text != "")
            {
                 Attachment att = new Attachment(this.textBox6.Text);
                 msg.Attachments.Add(att);
            }
           
                
            

            client.Send(msg);
            MessageBox.Show("已发送！");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}
