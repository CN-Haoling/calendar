using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssistant
{
    class TaskService
    {
        public static List<Tasks> GetAllTasks()
        {
            using (var db = new emailContext())
            {
                return db.Tasks.Include("TaskDetails").ToList();
            }
        }

        public static void RemoveTask(string id)
        {
            try
            {
                using (var db = new emailContext())
                {
                    Tasks task = db.Tasks.Include("TaskDetails").Where(x => x.TasksId == id).FirstOrDefault();
                    db.Tasks.Remove(task);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw new ApplicationException($"删除订单错误!");
            }
           
        }

        public static void UpdateTasks(Tasks newtask)
        {
            RemoveDetails(newtask.TasksId);
            using (var db = new emailContext())
            {
                db.Entry(newtask).State = EntityState.Modified;
                db.TaskDetails.AddRange(newtask.TaskDetails);
                db.SaveChanges();
            }
        }

        public static void RemoveDetails(string id)
        {
            using (var db = new emailContext())
            {
                var details = db.TaskDetails.Where(x => x.TasksId == id);
                db.TaskDetails.RemoveRange(details);
                db.SaveChanges();
            }
        }

        public static void Add(Tasks task)
        {

            using (var db = new emailContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

        }
    }

}
