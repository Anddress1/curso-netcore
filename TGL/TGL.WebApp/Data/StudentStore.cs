using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Juan",
                LastName = "Perez",
                Nit = "123456789"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 19,
                Name = "Daniel",
                LastName = "Chozo",
                Nit = "223456780"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 21,
                Name = "Jesus",
                LastName = "Zapata",
                Nit = "323456781"
            });
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }

    }
}
