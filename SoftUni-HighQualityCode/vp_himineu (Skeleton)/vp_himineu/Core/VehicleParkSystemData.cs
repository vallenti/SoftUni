namespace VehicleParkSystem.Core
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;
    using Interfaces;

    public class Database
    {
        public Database(int numberOfSectors)
        {
            ParkedCars = new Dictionary<IVehicle, string>();
            park = new Dictionary<string, IVehicle>();
            VehiclesByLicensePlate = new Dictionary<string, IVehicle>();
            VehiclesByStartTime = new Dictionary<IVehicle, DateTime>();
            VehiclesByOwner = new MultiDictionary<string, IVehicle>(false);
            Count = new int[numberOfSectors];
        }

        public Dictionary<IVehicle, string> ParkedCars { get; set; }
        public Dictionary<string, IVehicle> park { get; set; }
        public Dictionary<string, IVehicle> VehiclesByLicensePlate { get; set; }
        public Dictionary<IVehicle, DateTime> VehiclesByStartTime { get; set; }
        public MultiDictionary<string, IVehicle> VehiclesByOwner { get; set; }
        public int[] Count { get; set; }
    }
}
