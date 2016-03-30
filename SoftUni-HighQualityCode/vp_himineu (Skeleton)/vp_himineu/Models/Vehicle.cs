namespace VehicleParkSystem.Models
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using Interfaces;

    public abstract class Vehicle : IVehicle
    {
        private string licensePlate;
        private string owner;
        private decimal regularRate;
        private decimal overtimeRate;
        private int reservedHours;

        protected Vehicle(string licensePlate, string owner, int reservedHours)
        {
            this.LicensePlate = licensePlate;
            this.Owner = owner;
            this.ReservedHours = reservedHours;
        }

        public string LicensePlate
        {
            get
            {
                return this.licensePlate;
            }

            set
            {
                if (!Regex.IsMatch(value, @"[A-Z]{1,2}(\d{4})[A-Z]{2,}"))
                {
                    throw new ArgumentException("The license plate number is invalid.");
                }

                this.licensePlate = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The owner is required.");
                }

                this.owner = value;
            }
        }
        public decimal RegularRate
        {
            get
            {
                return this.regularRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format("The regular rate must be non-negative."));
                }

                this.regularRate = value;
            }
        }
        public decimal OvertimeRate
        {
            get
            {
                return this.overtimeRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format("The overtime rate must be non-negative."));
                }

                this.overtimeRate = value;
            }
        }
        public int ReservedHours
        {
            get
            {
                return this.reservedHours;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The reserved hours must be positive.");
                }

                this.reservedHours = value;
            }
        }

        public override string ToString()
        {
            var vehicle = new StringBuilder();
            vehicle.AppendFormat("{0} [{1}], owned by {2}", GetType().Name, LicensePlate, Owner);
            return vehicle.ToString();
        }
    }
}
