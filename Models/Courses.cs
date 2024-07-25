using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Interfaces;

namespace entregable_04.Models
{
    public class Courses : ICourses
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