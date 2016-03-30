using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQ
{
    class Student
    {
        public Student(string Name, int grade)
        {
            Name = Name;
            Grade = grade;
        }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
