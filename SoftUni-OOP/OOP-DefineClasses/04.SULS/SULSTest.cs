using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Person1", "LastName", 34);
            Trainer trainer1 = new Trainer("Trainer1", "LastNameT1", 22);
            JuniorTrainer jt1 = new JuniorTrainer("Junior1", "LNJunior1", 23);
            SeniorTrainer st1 = new SeniorTrainer("Senior1", "sen", 25);
            Student s1 = new Student("Student1", "LNStudent1", 22, 1234, 3.5);
            GraduateStudent gs1 = new GraduateStudent("Student1", "LNStudent1", 22, 1234, 3.5);
            CurrentStudent cs1 = new CurrentStudent("Student1", "LNStudent1", 22, 1232, 5.6, "oop");
            CurrentStudent cs2 = new CurrentStudent("Student2", "LNStudent2", 23, 1235, 6, "java");
            CurrentStudent cs3 = new CurrentStudent("Student3", "LNStudent3", 22, 1231, 4.6, "c#");
            OnlineStudent onlineStudent1 = new OnlineStudent("Online1", "LNonline1", 22, 2315, 4.3, "oop");
            OnsiteStudent onsitetudent1 = new OnsiteStudent("Onsite1", "LNonsite1", 22, 2332, 4.3, "java");
            DropoutStudent ds1 = new DropoutStudent("Drop1", "Out1", 22, 7677, 2.4, "poor scores");

            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(trainer1);
            people.Add(jt1);
            people.Add(st1);
            people.Add(s1);
            people.Add(gs1);
            people.Add(cs1);
            people.Add(cs2);
            people.Add(cs3);
            people.Add(onlineStudent1);
            people.Add(onsitetudent1);
            people.Add(ds1);

            people.OfType<CurrentStudent>().OrderBy(x => x.AverageGrade).ToList().ForEach(s => Console.WriteLine(s.StudentNumber+" | "+s.FirstName +" | "+s.LastName+" | "+s.AverageGrade+" | "+s.CurrentCourse ));
        }
    }
}
