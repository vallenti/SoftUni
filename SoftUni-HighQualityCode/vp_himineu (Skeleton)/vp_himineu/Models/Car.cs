using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VehicleParkSystem.Models
{
    public class Car : Vehicle
    {
        private const decimal CarRegularRate = 2m;
        private const decimal CarOvertimeRate = 3.5m;

        public Car(string licensePlate, string owner, int reservedHours)
            :base(licensePlate, owner, reservedHours)
        {
            this.RegularRate = CarRegularRate;
            this.OvertimeRate = CarOvertimeRate;
        }
    }
}
