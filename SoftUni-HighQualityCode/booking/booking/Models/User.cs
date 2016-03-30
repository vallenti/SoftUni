using System.Collections.Generic;
using System;
using HotelBookingSystem.Utilities;
using HotelBookingSystem.Interfaces;

namespace HotelBookingSystem.Models
{
    public class User : IDbEntity
    {
        private const int MinUsernameLength = 5;
        private const int MinPasswordLength = 6;
        private string username;
        private string password;

        public User(string username, string password, Roles role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.Bookings = new List<Booking>();
        }

        public int Id { get; set; }

        public string Username
        {
            get
            {
                return this.username;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format("The username cannot be null or empty."));
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
                    throw new ArgumentException(string.Format("The password cannot be null or empty."));
                }

                if (value.Length < MinPasswordLength)
                {
                    string message = string.Format("The venue {0} must be at least {1} symbols long.", nameof(password), MinPasswordLength);
                    throw new ArgumentException(message);
                }

                this.password = HashUtilities.GetSha256Hash(value);
            }
        }

        public Roles Role { get; private set; }

        public ICollection<Booking> Bookings { get; private set; }
    }
}
