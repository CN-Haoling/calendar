using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkAssistan
{
    class TaskDetail
    {
        [Key]
        public string StudentName { get; set; }

        public bool Status_Hw { get; set; }

        public string TasksId { get; set; }

        public TaskDetail()
        {
            StudentName = "";
            Status_Hw = false;
        }
        public TaskDetail(string name, bool status_Hw)
        {
            StudentName = name;
            this.Status_Hw = status_Hw;
        }


    }
}
