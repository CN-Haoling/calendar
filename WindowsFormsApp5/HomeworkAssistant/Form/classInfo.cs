using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkAssistant
{
    public partial class classInfo : Form
    {
        public classInfo()
        {
            InitializeComponent();
            stubindingSource.DataSource = StudentService.GetAllStudents();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_addstu_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInfo stufrm = new StudentInfo(new Student());
                if (stufrm.ShowDialog() == DialogResult.OK)
                {
                    StudentService.Add(stufrm.Stu);
                }
                stubindingSource.DataSource = StudentService.GetAllStudents();
                stubindingSource.ResetBindings(false);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_delstu_Click(object sender, EventArgs e)
        {
            Student StuClickedNow = stubindingSource.Current as Student;
            if (StuClickedNow == 
                null)
            {
                MessageBox.Show("请选择一个学生");
                return;
            }
            StudentService.RemoveStudent(StuClickedNow.Id);
            stubindingSource.DataSource = StudentService.GetAllStudents();
            stubindingSource.ResetBindings(false);
        }
    }
}
