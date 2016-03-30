using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndCourses
{
    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
        public int CompareTo(Student other)
        {
            var lastNameCompareResult = this.LastName.CompareTo(other.LastName);
            if (lastNameCompareResult != 0)
            {
                return lastNameCompareResult;
            }
            else
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
        }
    }
}
