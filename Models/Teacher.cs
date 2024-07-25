using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Enums;

namespace entregable_04.Models
{
    public class Teacher : Person
    {
        //Attributes
        private double salary { get; set; }
        public DateOnly HiringDate { get; set; }
        public List<Subject>? SubjectsList { get; set; }

        //Constructor
        public Teacher(string name, string lastName, TypeDocument documentType, string? numberDocument, DateOnly birthDate, string? email, string? phoneNumber, string? guardianName, double salary,DateOnly hiringDate, List<Subject>? subjectsList)
            : base(name, lastName, documentType, numberDocument, birthDate, email, phoneNumber)
        {
            Salary = salary;
            HiringDate = hiringDate;
            SubjectsList = subjectsList;
        }

        //Properties GETTER AND SETTER
        public double Salary { get =>  salary; set => salary = (double)value; }

        //Methods
        public double CalculateSeniority()
        {
            return 1.1;
        }

        public double GetSalary()
        {
            return Salary;
        }
    }
}