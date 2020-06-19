using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkAssistant
{
    public class TaskDetail
    {
        [Key]
        [Column(Order = 1)]
        public string TasksId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string StuId { get; set; }
        
        public string StudentName { get; set; }

        public bool Status_Hw { get; set; }
       

        public TaskDetail()
        {
            StudentName = "";
            Status_Hw = false;
        }

        public TaskDetail(string tasksId, string stuId, string studentName, bool status_Hw)
        {
            TasksId = tasksId;
            StuId = stuId;
            StudentName = studentName;
            Status_Hw = status_Hw;
        }
    }
}
