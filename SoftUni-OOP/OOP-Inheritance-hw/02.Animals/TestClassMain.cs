using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class TestClassMain
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo",2,'m'),
                new Dog("Balkan",15,'m'),
                new Dog("Vihar",6,'m'),
                new Dog("Lasi",6,'f'),
                new Frog("Kvak",2,'m'),
                new Frog("Kvak2",5,'f'),
                new Frog("Froggy",1,'f'),
                new Frog("Frogger",3,'m'),
                new Cat("Koti",2,'f'),
                new Cat("Mujaga",5,'m'),
                new Cat("GolqmoKoti",4,'f'),
                new Kitten("Kotti",1),
                new Kitten("Kotti2",3),
                new Kitten("Kotti3",5),
                new Kitten("Kotti4",6),
                new Tomcat("Tom1",5),
                new Tomcat("Tom2",3),
                new Tomcat("Tom3",1)
            };
            animals.GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderByDescending(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine(group.AnimalName + " - " + group.AverageAge));
        }
    }
}
