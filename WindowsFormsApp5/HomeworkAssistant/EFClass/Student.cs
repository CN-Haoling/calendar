using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssistant
{
    public class Student
    {
        public Student() { }
        public Student(string id, string name, string email)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Email == student.Email;
        }

        public override int GetHashCode()
        {
            var hashCode = 1231508573;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
