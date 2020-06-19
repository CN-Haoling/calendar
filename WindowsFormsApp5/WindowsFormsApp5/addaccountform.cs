using MailControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class AddAccount : Form
    {
        Users userx;
        public AddAccount(Users u1)
        {
            InitializeComponent();
            userx = u1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1.username = textBox3.Text;
            user1.userhost = "imap.qq.com";
            user1.userAdd = textBox1.Text;
            user1.userCode = textBox2.Text;
            userx.insert(user1);



            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
