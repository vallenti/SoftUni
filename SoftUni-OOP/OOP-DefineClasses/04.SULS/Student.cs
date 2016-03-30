using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                this.studentNumber = value;
            }
        }
        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                this.averageGrade = value;
            }
        }
        public Student(string firstName, string lastname, int age, int studentNumber, double averageGrade)
            : base(firstName,lastname,age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }
    }
}
