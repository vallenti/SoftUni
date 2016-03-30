namespace BangaloreUniversityLearningSystem.Models
{
    using System;
    using System.Collections.Generic;
    using Utilities;

    public class User
    {
        private const int MinUsernameLength = 5;
        private const int MinPassowrdLength = 6;
        private string username;
        private string password;

        public User(string username, string password, Role role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.Courses = new List<Course>();
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The username cannot be null or empty");
                }

                if (value.Length < MinUsernameLength)
                {
                    string message = string.Format("The {0} must be at least {1} symbols long.", nameof(username), MinUsernameLength);
                    throw new ArgumentException(message);
                }

                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The password cannot be null or empty string.");
                }

                if (value.Length < MinPassowrdLength)
                {
                    string message = string.Format("The {0} must be at least {1} symbols long.", nameof(password), MinPassowrdLength);
                    throw new ArgumentException(message);
                }

                this.password = HashUtilities.HashPassword(value);
            }
        }

        public Role Role { get; private set; }

        public IList<Course> Courses { get; private set; }
    }
}
