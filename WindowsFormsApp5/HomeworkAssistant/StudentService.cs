using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssistan
{
    class StudentService
    {
        public static List<Student> GetAllStudents()
        {
            using (var db = new emailContext())
            {
                return db.Students.ToList();
            }
        }

        public static void RemoveStudent(string id)
        {
            using (var db = new emailContext())
            {
                Student stu = db.Students.Where(x => x.Id == id).FirstOrDefault();      
                db.Students.Remove(stu);
                db.SaveChanges();
            }
        }

        public static void UpdateStudent(string id,Student stu)
        {
            using (var db = new emailContext())
            {
                db.Students.Remove(db.Students.Where(s => s.Id == id).FirstOrDefault());
                db.Students.Add(stu);
                db.SaveChanges();
            }
        }

        public static void Add(Student stu)
        {
      
            using (var db = new emailContext())
             {
                 db.Students.Add(stu);
                 db.SaveChanges();
            }               
            
        }
    }
}
