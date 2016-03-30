using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VehicleParkSystem.Models
{
    public class Motorbike : Vehicle
    {
        private const decimal BikeRegularRate = 1.35m;
        private const decimal BikeOvertimeRate = 3m;

        public Motorbike(string licensePlate, string owner, int reservedHours)
            :base(licensePlate, owner, reservedHours)
        {
            this.RegularRate = BikeRegularRate;
            this.OvertimeRate = BikeOvertimeRate;
        }
    }
}
