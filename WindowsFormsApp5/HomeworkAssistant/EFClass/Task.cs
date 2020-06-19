using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssistant
{
    public class Tasks
    {
        public string TasksId { get; set; }

        public string Name { get; set; }

        public DateTime DDL { get; set; }

        public string Format { get; set; }   //作业附件命名的前缀格式

        public List<TaskDetail> TaskDetails { get; set; }

        public Tasks()
        {
            TasksId = Guid.NewGuid().ToString();
            TaskDetails = new List<TaskDetail>();
        }

        public Tasks(string name, DateTime dDL, string format):this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            DDL = dDL;
            Format = format ?? throw new ArgumentNullException(nameof(format));
        }

        public void  AddDetail(TaskDetail td)
        {
            TaskDetails.Add(td);
        }

        /*将学生信息导入该task的detail*/
        public void AddDetails()
        {
            using (var db = new emailContext())
            {
                List<Student> students = db.Students.ToList();
                foreach (Student x in students)
                {
                    TaskDetail detail = new TaskDetail(TasksId,x.Id,x.Name, false);
                    TaskDetails.Add(detail);
                }
            }
        }
        
        public Tasks UpdateStatus(List<string> StuId)
        {
            //按已提交的学生名单逐个修改状态
            foreach(string x in StuId)
            {
                if(TaskDetails.Exists(t => t.StuId == x))
                {
                    TaskDetails.Find(t => t.StuId == x).Status_Hw = true;
                }                
            }
            return this;
        }
        



    }
}
