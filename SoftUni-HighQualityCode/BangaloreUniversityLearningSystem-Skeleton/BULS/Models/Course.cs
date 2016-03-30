namespace BangaloreUniversityLearningSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MinNameLength = 5;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.Lectures = new List<Lecture>();
            this.Students = new List<User>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name cannot be null or empty");
                }

                if (value.Length < MinNameLength)
                {
                    string message = string.Format("The course name must be at least {0} symbols long.", MinNameLength);
                    throw new ArgumentException(message);
                }

                this.name = value;
            }
        }

        public IList<Lecture> Lectures { get; private set; }

        public IList<User> Students { get; private set; }

        public void AddLecture(Lecture lecture)
        {
            this.Lectures.Add(lecture);
        }

        public void AddStudent(User student)
        {
            this.Students.Add(student);
            student.Courses.Add(this);
        }
    }
}
