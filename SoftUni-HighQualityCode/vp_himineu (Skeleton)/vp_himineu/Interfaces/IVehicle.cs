using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkSystem.Interfaces
{
    public interface IVehicle
    {
        string LicensePlate { get; set; }
        string Owner { get; set; }
        int ReservedHours { get; set; }
        decimal RegularRate { get; set; }
        decimal OvertimeRate { get; set; }
    }
}
