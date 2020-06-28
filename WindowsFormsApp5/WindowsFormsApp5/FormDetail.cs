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

namespace WindowsFormsApp5
{
    public partial class FormDetail : Form

    {
        MC DetailControl;
        MailMessage mesg;
        public FormDetail(MailMessage msg,MC a)
        {
             mesg = msg;
            InitializeComponent();
            webBrowser1.DocumentText = msg.Body;
            if (msg.From != null)
            {
                textBox1.Text = msg.From.ToString();
            }
            textBox2.Text = msg.Subject;
            attachmentsBindingSource.DataSource = msg.Attachments;
            DetailControl = a;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Attachment x = attachmentsBindingSource.Current as Attachment;
            DetailControl.exportAttachments(x);
            System.Diagnostics.Process.Start(Application.StartupPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetailControl.download(mesg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MailControl.User Sender = DetailControl.getUser();
            send form1 = new send(mesg.From.Address,Sender);
            form1.Show();
        }

        private void sizeChaneg(object sender, EventArgs e)
        {
            webBrowser1.Height = 1024;

        }

        private void FormDetail_Load(object sender, EventArgs e)
        {

        }

        private void rs(object sender, EventArgs e)
        {
            webBrowser1.Height = this.Size.Height -140;
        }
    }
}
