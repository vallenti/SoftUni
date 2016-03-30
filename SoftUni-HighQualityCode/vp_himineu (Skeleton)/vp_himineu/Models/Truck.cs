using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace VehicleParkSystem.Models
{
    public class Truck : Vehicle
    {
        private const decimal TruckRegularRate = 4.75m;
        private const decimal TruckOvertimeRate = 6.2m;

        public Truck(string licensePlate, string owner, int reservedHours)
            :base(licensePlate, owner, reservedHours)
        {
           this.RegularRate = TruckRegularRate;
           this.OvertimeRate = TruckOvertimeRate;
        }
    }
}
