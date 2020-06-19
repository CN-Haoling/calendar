using MailControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           

            loginform login = new loginform();
            login.ShowDialog();
            //登陆结果正确之后显示主界面
            if (login.DialogResult == DialogResult.OK)
            {   
                
                Application.Run(new mainform(login.now));
                login.Dispose();
            }
            else if (login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                return;
            }
        }
    }
}
