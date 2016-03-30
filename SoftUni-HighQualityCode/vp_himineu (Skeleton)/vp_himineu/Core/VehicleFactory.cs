using System;
using VehicleParkSystem.Interfaces;
using VehicleParkSystem.Models;

namespace VehicleParkSystem.Core
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string type, string licensePlate, string owner, int reservedHours)
        {
            switch (type)
            {
                case "car":
                    return new Car(licensePlate, owner, reservedHours);
                case "motorbike":
                    return new Motorbike(licensePlate, owner, reservedHours);
                case "truck":
                    return new Truck(licensePlate, owner, reservedHours);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
