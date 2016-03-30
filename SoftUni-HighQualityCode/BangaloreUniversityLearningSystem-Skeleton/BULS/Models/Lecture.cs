namespace BangaloreUniversityLearningSystem.Models
{
    using System;

    public class Lecture
    {
        private const int MinNameLength = 3;
        private string name;

        public Lecture(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The lecture name cannot be null or empty");
                }

                if (value.Length < MinNameLength)
                {
                    throw new ArgumentException(string.Format("The lecture name must be at least {0} symbols long.", MinNameLength));
                }

                this.name = value;
            }
        }
    }
}
