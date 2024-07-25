using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Models;

namespace entregable_04.Interfaces
{
    public interface ITeacher
    {
        // Propiedades
        double Salary { get; set; }
        DateOnly HiringDate { get; set; }
        List<Subjects> SubjectsList { get; set; }

        double CalculateSeniority();
        double GetSalary();
    }
}