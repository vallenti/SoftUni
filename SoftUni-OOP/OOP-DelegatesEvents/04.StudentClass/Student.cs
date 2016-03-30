using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StudentClass
{

    delegate void PropertyChangedEventHandler(Student student, PropertyChangedEventArgs args);

    class Student
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private int age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name", this.Name, value));
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString()));
                }
                this.age = value;
            }
        }
    }
}
