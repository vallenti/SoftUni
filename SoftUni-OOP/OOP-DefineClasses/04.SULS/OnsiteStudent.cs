using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class OnsiteStudent : CurrentStudent
    {
        public int Visits { get; set; }

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.Visits = 0;
        }

        public void AddVisit()
        {
            this.Visits++;
        }
    }
}
