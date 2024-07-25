using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Enums;

namespace entregable_04.Models
{
    public class Student : Person
    {
        //Attributes
        public string? GuardianName { get; set; }
        public List<double> Scores { get; set; }

        //Constructor
        public Student(string name, string lastName, TypeDocument documentType, string? numberDocument, DateOnly birthDate, string? email, string? phoneNumber, string? guardianName)
            : base(name, lastName, documentType, numberDocument, birthDate, email, phoneNumber)
        {
            GuardianName = guardianName;
            Scores = new List<double>();
        }

        //Methods
        public void AddScore(double score)
        {

        }
        public double CalculateAverageGrade()
        {
            return 1.1;
        }
    }
}