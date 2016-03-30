using System.Collections.Generic;
using System;
using HotelBookingSystem.Interfaces;

namespace HotelBookingSystem.Models
{
    public class Venue : IDbEntity
    {
        private const int MinNameLength = 3;
        private const int MinAddressLength = 3;
        private string name;
        private string address;

        public Venue(string name, string address, string description, User owner)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.Owner = owner;
            this.Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }

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
                    throw new ArgumentException(string.Format("The venue name cannot be null or empty"));
                }

                if(value.Length < MinNameLength)
                {
                    string message = string.Format("The venue {0} must be at least {1} symbols long.", nameof(name), MinNameLength);
                    throw new ArgumentException(message);
                }

                this.name = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format("The venue address cannot be null or empty"));
                }

                if (value.Length < MinNameLength)
                {
                    string message = string.Format("The venue {0} must be at least {1} symbols long.", nameof(address), MinNameLength);
                    throw new ArgumentException(message);
                }

                this.address = value;
            }
        }

        public string Description { get; set; }

        public User Owner { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
