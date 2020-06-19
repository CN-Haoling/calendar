using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HomeworkAssistan
{
    class emailContext: DbContext
   {
        public emailContext() : base(("emailDataBase"))
        { Database.SetInitializer(new DropCreateDatabaseIfModelChanges<emailContext>()); }

        public DbSet<Student> Students { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TaskDetail> TaskDetails { get; set; }
    }
    
    
}
