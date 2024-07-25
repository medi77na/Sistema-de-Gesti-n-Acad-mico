using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entregable_04.Models
{
    public class Courses
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Courses(string name, List<Student> students)
        {
            Id = Guid.NewGuid();
            Name = name;
            Students = students;
        }
    }
}