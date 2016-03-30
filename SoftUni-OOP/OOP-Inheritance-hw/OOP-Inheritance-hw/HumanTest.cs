using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_hw
{
    class HumanTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan","Ivanov","FN12345"),
                new Student("Georgi","Georgiev","FN23456"),
                new Student("Petar","Petrov","FN12745"),
                new Student("Pesho","Peshev","FN12145"),
                new Student("Mario","Mariov","FN11345"),
                new Student("Nikola","Nikolov","FN52345"),
                new Student("Stamat","Stamatov","FN62345"),
                new Student("Evgeni","Evgeniev","FN12645"),
                new Student("Blagoi","Blagoev","FN18345"),
                new Student("Minko","Minkov","FN12399"),
            };
            students.OrderBy(x => x.FacultyNumber)
                .ToList()
                .ForEach(s => Console.WriteLine(s.FacultyNumber + "|" +s.FirstName+" "+s.LastName));

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Gosho","Goshev",100,8),
                new Worker("Pesho","Pesho",1000,8),
                new Worker("Mitko","Mitkov",200,6),
                new Worker("Dimitar","Dimitrov",300,6),
                new Worker("Goshku","Goshkuv",500,8),
                new Worker("Doncho","Donchev",40,4),
                new Worker("Yoncho","Yonchev",100,8),
                new Worker("Samuil","Samuilov",150,4),
                new Worker("Danko","Dankov",280,8),
                new Worker("Petar","Petarov",420.80,8),
            };
            Console.WriteLine();
            workers.OrderByDescending(x => x.MoneyPerHour())
                .ToList()
                .ForEach(w => Console.WriteLine(w.FirstName + " " + w.LastName + " - " + w.MoneyPerHour()));
            Console.WriteLine();
            List<Human> combinedList = new List<Human>();
            combinedList.AddRange(students);
            combinedList.AddRange(workers);
            combinedList.OrderBy(x => x.FirstName)
                .ThenBy(y => y.LastName)
                .ToList()
                .ForEach(c => Console.WriteLine(c.FirstName + " " + c.LastName+" -> "+c.GetType().Name));
        }
    }
}
