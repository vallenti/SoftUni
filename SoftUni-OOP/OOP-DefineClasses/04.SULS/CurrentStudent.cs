using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class CurrentStudent : Student
    {
        public string CurrentCourse { get; set; }

        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber,averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }
    }
}
