using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssistan
{
    class TaskService
    {
        public static List<Tasks> GetAllTasks()
        {
            using (var db = new emailContext())
            {
                return db.Tasks.ToList();
            }
        }

        public static void RemoveTask(string id)
        {
            using (var db = new emailContext())
            {
                Tasks task = db.Tasks.Where(x => x.TasksId == id).FirstOrDefault();
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
        }

        public static void UpdateTasks(string id, Tasks task)
        {
            using (var db = new emailContext())
            {
                db.Tasks.Remove(db.Tasks.Where(s => s.TasksId == id).FirstOrDefault());
                db.Tasks.Add(task);
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
