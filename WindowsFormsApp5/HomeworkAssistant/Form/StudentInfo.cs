using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HomeworkAssistant
{
    public partial class StudentInfo : Form
    {
        string regex = @"^(.+)\@(.+)\.com$";//匹配邮箱的pattern
        public Student Stu { get; set; }

        public StudentInfo()
        {
            InitializeComponent();
        }
        public StudentInfo(Student stu) : this()
        {
            this.Stu = stu;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Stu.Id = txt_Id.Text;
            Stu.Name = txt_Name.Text;
            if (Regex.IsMatch(txt_email.Text, regex))
            {
                Stu.Email = txt_email.Text;
            }
            else { throw new ArgumentException("请输入正确的邮箱地址！"); }
        }
    }
}
