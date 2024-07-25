using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Models;

namespace entregable_04.Interfaces
{
    public class ICourses
    {
        Guid Id { get; set; }
        string Name { get; set; }
        List<Student> Students { get; set; }
    }
}