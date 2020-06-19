using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssistan
{
    class Tasks
    {
        public Tasks()
        {
            TasksId = Guid.NewGuid().ToString();
            TaskDetails = new List<TaskDetail>();
        }

        public Tasks( string name, DateTime dDL):this()
        {
            Name = name;
            DDL = dDL;
        }

        public string TasksId { get; set; }

        public string Name { get; set; }

        public DateTime DDL { get; set; }

        public List<TaskDetail> TaskDetails { get; set; }
    }
}
