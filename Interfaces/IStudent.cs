using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entregable_04.Interfaces
{
    public interface IStudent
    {
        string GuardianName { get; set; }
        List<double> Scores { get; set; }

        void AddScore(double grade);
        double CalculateAverageGrade();
        
    }
}