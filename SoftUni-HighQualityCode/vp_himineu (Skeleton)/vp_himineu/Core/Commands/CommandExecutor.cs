using System;
using VehicleParkSystem.Interfaces;

namespace VehicleParkSystem.Core.Commands
{
    public class CommandExecutor
    {
        VehiclePark VehiclePark { get; set; }

        public string ReturnCommand(ICommand command)
        {
            if (command.Name != "SetupPark" && VehiclePark == null)
                    return "The vehicle park has not been set up";

            switch (command.Name)
            {
                case "SetupPark":
                    var database = new Database(int.Parse(command.Parameters["sectors"]));
                    this.VehiclePark = new VehiclePark(database, int.Parse(command.Parameters["sectors"]), int.Parse(command.Parameters["placesPerSector"]));
                    return "Vehicle park created";
                case "Park":
                    return VehiclePark.InsertVehicle(
                        VehicleFactory.CreateVehicle(command.Parameters["type"], command.Parameters["licensePlate"], command.Parameters["owner"], int.Parse(command.Parameters["hours"])),
                        int.Parse(command.Parameters["sector"]),
                        int.Parse(command.Parameters["place"]),
                            DateTime.Parse(command.Parameters["time"],
                            null,
                            System.Globalization.DateTimeStyles.RoundtripKind));
                case "Exit":
                    return VehiclePark.ExitVehicle(
                            command.Parameters["licensePlate"], 
                            DateTime.Parse(command.Parameters["time"], 
                                null, 
                                System.Globalization.DateTimeStyles.RoundtripKind),
                            decimal.Parse(command.Parameters["paid"]));
                case "Status":
                    return VehiclePark.GetStatus();
                case "FindVehicle":
                    return VehiclePark.FindVehicle(command.Parameters["licensePlate"]);
                case "VehiclesByOwner":
                    return VehiclePark.FindVehiclesByOwner(command.Parameters["owner"]);
                default:
                    throw new InvalidOperationException("Invalid command.");  
                }

            return "";
        }
    }
}















