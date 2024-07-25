using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace entregable_04.Models
{
    public class Subject
    {
        public Guid Id { get; }
        public string? Name { get; set; }
        public List<Teacher> Teachers { get;}

        public Subject(string name, List<Teacher> teachers)
        {
            Id = Guid.NewGuid();
            Name = name;
            Teachers = teachers;
        }
    }
}