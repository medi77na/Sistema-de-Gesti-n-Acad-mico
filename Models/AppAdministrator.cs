using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entregable_04.Models
{
    public class AppAdministrator
    {
        List<Student> Students { get; }
        List<Teacher> Teachers { get; }

        public AppAdministrator()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void ShowStudents()
        {

        }

        public void ShowTeachers()
        {

        }

    }
}