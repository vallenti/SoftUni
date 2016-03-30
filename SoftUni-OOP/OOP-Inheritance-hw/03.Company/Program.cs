using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer(12, "ivan", "ivanov", 1500);
            dev.AddProject(new Project("proj1", new DateTime(),"detaillssss", ProjectState.Open));
            dev.AddProject(new Project("proj2", new DateTime(),"detaillssss", ProjectState.Closed));
            dev.AddProject(new Project("proj3", new DateTime(),"detaillssss", ProjectState.Open));
            SalesEmployee sal = new SalesEmployee(11, "petar", "petrov", 1200);
            sal.AddSale(new Sale("pc", new DateTime(), 1231.23m));
            sal.AddSale(new Sale("hdd", new DateTime(), 23.23m));
            sal.AddSale(new Sale("wow", new DateTime(), 123131.23m));
            sal.AddSale(new Sale("gg", new DateTime(), 12231.23m));
            Manager man = new Manager(10, "Mlad", "Merinjei", 5000, Department.Sales);
            man.AddEmployee(sal);
            man.AddEmployee(dev);
            List<Employee> employees = new List<Employee>();
            employees.Add(man);
            employees.Add(sal);
            employees.Add(dev);
            employees.ForEach(Console.WriteLine);
        }
    }
}
