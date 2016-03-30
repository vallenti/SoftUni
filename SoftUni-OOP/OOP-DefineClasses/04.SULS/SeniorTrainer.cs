using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastname, int age)
            : base(firstName, lastname, age)
        {

        }
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} course was deleted successfully.",courseName);
        }
    }
}
