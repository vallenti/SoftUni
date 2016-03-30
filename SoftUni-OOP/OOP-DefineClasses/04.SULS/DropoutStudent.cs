using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class DropoutStudent : Student
    {
        public string DropoutReason { get; set; }

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public void Reapply()
        {
            Console.WriteLine("{0} {1} - {2} years old",FirstName, LastName, Age);
            Console.WriteLine("SN: {0}",StudentNumber);
            Console.WriteLine("Average grade: {0}",AverageGrade);
            Console.WriteLine("Dropout reason: {0}",DropoutReason);
        }
    }
}
