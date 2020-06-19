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
    public partial class HwChecker : Form
    {
        public int MissAcount { get; set; }

        public HwChecker()
        {
            InitializeComponent();
            TaskbindingSource.DataSource = TaskService.GetAllTasks();
            lbl_MissAcount.DataBindings.Add("text", this, "MissAcount");
        }

        private void dgv_class_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tasks task = TaskbindingSource.Current as Tasks;
            if (task != null) { 
                 TaskDetailbindingSource.DataSource = task.TaskDetails;

                 MissAcount = task.TaskDetails.Count(x => x.Status_Hw == false);
                 lbl_MissAcount.Text = MissAcount.ToString();
            }
        }

        //是否仅显示未交作业的同学
        private void checkbox_ShowMissStu_CheckedChanged(object sender, EventArgs e)
        {
            Tasks task = TaskbindingSource.Current as Tasks;
            if (checkbox_ShowMissStu.Checked)
            {
                TaskDetailbindingSource.DataSource = task.TaskDetails.Where(x => x.Status_Hw == false);
                MissAcount = task.TaskDetails.Count(x => x.Status_Hw == false);
                TaskDetailbindingSource.ResetBindings(false);
            }
            else
            {
                if (task != null)
                {
                    TaskDetailbindingSource.DataSource = task.TaskDetails;
                    TaskDetailbindingSource.ResetBindings(false);
                    MissAcount = task.TaskDetails.Count(x => x.Status_Hw == false);
                }
            }
        }

        //选择已到期/未到期的作业
        private void cbo_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_class.SelectedIndex == 0)
            {
                TaskbindingSource.DataSource = TaskService.GetAllTasks();
                TaskDetailbindingSource.ResetBindings(false);
            }
            else if(cbo_class.SelectedIndex==1)
            {
                List<Tasks> AllTasks = TaskService.GetAllTasks();
                TaskbindingSource.DataSource = AllTasks.Where(x => x.DDL.CompareTo(DateTime.Today) <= 0);
                TaskDetailbindingSource.ResetBindings(false);
            }
            else
            {
                List<Tasks> AllTasks = TaskService.GetAllTasks();
                TaskbindingSource.DataSource = AllTasks.Where(x => x.DDL.CompareTo(DateTime.Today) > 0);
                TaskDetailbindingSource.ResetBindings(false);
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            Tasks task = TaskbindingSource.Current as Tasks;
            if (task == null) MessageBox.Show("您选了个寂寞");
            else if (task.DDL > DateTime.Now) MessageBox.Show("该DDL仍未到期");
            else
            {
                FolderBrowserDialog fileDialog = new FolderBrowserDialog();
                if(fileDialog.ShowDialog()==DialogResult.OK)
                {
                    List<string> stuId = Statistic.DownloadAttachments(task, fileDialog.SelectedPath);
                    TaskService.UpdateTasks(task.UpdateStatus(stuId));
                    MissAcount = task.TaskDetails.Count(x => x.Status_Hw == false);
                    lbl_MissAcount.Text = MissAcount.ToString();
                    QueryAll();

                   
                    MessageBox.Show($"下载完成,共下载{stuId.Count}个文件");
                    if (stuId.Count != 0) { 
                          System.Diagnostics.Process.Start(fileDialog.SelectedPath);
                    }
                }
            }
        }
        private void QueryAll()
        {
            TaskbindingSource.DataSource = TaskService.GetAllTasks();
            TaskbindingSource.ResetBindings(false);
            TaskDetailbindingSource.ResetBindings(false);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Tasks task = TaskbindingSource.Current as Tasks;
            if (task == null) MessageBox.Show("您选了个寂寞");
            else
            {
                List<string> stuId = Statistic.GetFilteredStuId(task);
                TaskService.UpdateTasks(task.UpdateStatus(stuId));
                MissAcount = task.TaskDetails.Count(x => x.Status_Hw == false);
                lbl_MissAcount.Text = MissAcount.ToString();
                QueryAll();
            }

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            Tasks task = TaskbindingSource.Current as Tasks;
            try
            {
                TaskService.RemoveTask(task.TasksId);
                QueryAll();            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
