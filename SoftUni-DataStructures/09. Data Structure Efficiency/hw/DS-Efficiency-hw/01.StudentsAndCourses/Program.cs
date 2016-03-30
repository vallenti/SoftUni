using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../students.txt";
            var coursesAndStudents = new SortedDictionary<string, SortedSet<Student>>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split('|').Select(s => s.Trim()).ToArray();
                    string firstName = line[0];
                    string lastName = line[1];
                    string course = line[2];
                    var student = new Student(firstName, lastName);
                    if(!coursesAndStudents.ContainsKey(course))
                    {
                        coursesAndStudents.Add(course, new SortedSet<Student>());
                    }

                    coursesAndStudents[course].Add(student);
                }
            }

            foreach (var element in coursesAndStudents)
            {
                Console.WriteLine("{0}: {1}", element.Key, string.Join(", ",element.Value));
            }
        }
    }
}
