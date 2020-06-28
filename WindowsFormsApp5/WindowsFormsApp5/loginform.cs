using MailControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class loginform : Form
    {
        Users user1 = new Users();
        
        List<User> users = new List<User>();
       
        List<string> names = new List<string>();
        List<string> namet = new List<string>();

        public User now;
        public loginform()
        {
            InitializeComponent();

            user1.init();
            refreshUser();
        }

        public void refreshUser()
        {
            users = new List<User>();
            users = user1.getAll();
            names = new List<string>();
            foreach (User user in users)
            {
                names.Add(user.username);


            }
            comboBox1.DataSource = namet;
            comboBox1.DataSource = names;
            comboBox1.Refresh();
        }
        public void loginbutton_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            var user = user1.Quaryname(name);
            now = user[0];//获取user

            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }
        private void loginformClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addacountbutton_Click(object sender, EventArgs e)
        {
            AddAccount addacount = new AddAccount(user1);
            Hide();
            addacount.ShowDialog();
            addacount.Dispose();
            addacount.Close();
            Show();
            refreshUser();
        }
    }
}
