using System;
using VehicleParkSystem.Models;

namespace VehicleParkSystem.Interfaces
{
    interface IVehiclePark
    {
        // TODO: Documentar esse método
        string InsertVehicle(IVehicle car, int sector, int placeNumber, DateTime startTime);

        // TODO: Documentar esse método
        string ExitVehicle(string licensePlate, DateTime endTime, decimal amountPaid);
        // TODO: Documentar esse método
        string GetStatus();
        // TODO: Documentar esse método
        string FindVehicle(string licensePlate);
        // TODO: Documentar esse método
        string FindVehiclesByOwner(string owner);
    }
}
