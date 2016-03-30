namespace VehicleParkSystem.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;
    using Models;

    public class VehiclePark : IVehiclePark
    {
        private ParkLayout layout;
        public Database Data;

        public VehiclePark(Database data, int numberOfSectors, int placesPerSector)
        {
            layout = new ParkLayout(numberOfSectors, placesPerSector);
            Data = data;
        }

        public string InsertVehicle(IVehicle vehicle, int sector, int placesPerSector, DateTime enterTime)
        {
            this.ValidateParameters(vehicle, sector, placesPerSector, enterTime);

            this.Data.ParkedCars[vehicle] = string.Format("({0},{1})", sector, placesPerSector); ;
            this.Data.park[string.Format("({0},{1})", sector, placesPerSector)] = vehicle;
            this.Data.VehiclesByLicensePlate[vehicle.LicensePlate] = vehicle;
            this.Data.VehiclesByStartTime[vehicle] = enterTime;
            this.Data.VehiclesByOwner[vehicle.Owner].Add(vehicle);
            this.Data.Count[sector - 1]++;

            return string.Format("{0} parked successfully at place ({1},{2})", vehicle.GetType().Name, sector, placesPerSector);
        }

        public string ExitVehicle(string licensePlate, DateTime leaveTime, decimal money)
        {
            var vehicle = (Data.VehiclesByLicensePlate.ContainsKey(licensePlate)) ? Data.VehiclesByLicensePlate[licensePlate] : null;
            if (vehicle == null)
            {
                return string.Format("There is no vehicle with license plate {0} in the park", licensePlate);
                
            }

            var enterTime = Data.VehiclesByStartTime[vehicle];
            int endd = (int)Math.Round((leaveTime - enterTime).TotalHours);
            var ticket = new StringBuilder();
            ticket.AppendLine(new string('*', 20))
                .AppendFormat("{0}", vehicle.ToString())
                .AppendLine()
                .AppendFormat("at place {0}", Data.ParkedCars[vehicle])
                .AppendLine()
                .AppendFormat("Rate: ${0:F2}", (vehicle.ReservedHours * vehicle.RegularRate))
                .AppendLine()
                .AppendFormat("Overtime rate: ${0:F2}", (endd > vehicle.ReservedHours ? (endd - vehicle.ReservedHours) * vehicle.OvertimeRate : 0))
                .AppendLine()
                .AppendLine(new string('-', 20))
                .AppendFormat("Total: ${0:F2}", (vehicle.ReservedHours * vehicle.RegularRate + (endd > vehicle.ReservedHours ? (endd - vehicle.ReservedHours) * vehicle.OvertimeRate : 0)))
                .AppendLine()
                .AppendFormat("Paid: ${0:F2}", money)
                .AppendLine()
                .AppendFormat("Change: ${0:F2}", money - ((vehicle.ReservedHours * vehicle.RegularRate) + (endd > vehicle.ReservedHours ? (endd - vehicle.ReservedHours) * vehicle.OvertimeRate : 0)))
                .AppendLine()
                .Append(new string('*', 20));
            //DELETE
            int sector = int.Parse(Data.ParkedCars[vehicle].Split(new[] { "(", ",", ")" }, StringSplitOptions.RemoveEmptyEntries)[0]);
            Data.park.Remove(Data.ParkedCars[vehicle]);
            Data.ParkedCars.Remove(vehicle);
            Data.VehiclesByLicensePlate.Remove(vehicle.LicensePlate);
            Data.VehiclesByStartTime.Remove(vehicle);
            Data.VehiclesByOwner.Remove(vehicle.Owner, vehicle);
            Data.Count[sector - 1]--;
            //END OF DELETE
            return ticket.ToString();
        }

        public string GetStatus()
        {
            var places = Data.Count.Select(
                (takenPlaces, sectorNumber) => string.Format(
                        "Sector {0}: {1} / {2} ({3}% full)",
                        sectorNumber + 1,
                        takenPlaces,
                        layout.Places,
                        Math.Round((double)takenPlaces / layout.Places * 100)));

            return string.Join(Environment.NewLine, places);
        }

        public string FindVehicle(string licensePlate)
        {
            var vehicle = (Data.VehiclesByLicensePlate.ContainsKey(licensePlate)) ? Data.VehiclesByLicensePlate[licensePlate] : null;
            if (vehicle == null)
            {
                return string.Format("There is no vehicle with license plate {0} in the park", licensePlate);
            }
            else
            {
                return FormatVehiclesForPrinting(new[] { vehicle });
            }
        }

        public string FindVehiclesByOwner(string owner)
        {
            var vehicle = Data.VehiclesByOwner.ContainsKey(owner) ? Data.VehiclesByOwner[owner] : null;
            if (vehicle == null)
                return string.Format("No vehicles by {0}", owner);
            else
            {
                var foundVehicles = this.Data.VehiclesByOwner[owner]
                    .OrderBy(v => this.Data.VehiclesByStartTime[v])
                    .ThenBy(v => v.LicensePlate);
                return string.Join(Environment.NewLine, this.FormatVehiclesForPrinting(foundVehicles));
            }
        }

        private string FormatVehiclesForPrinting(IEnumerable<IVehicle> vehicles)
        {
            return string.Join(
                Environment.NewLine,
                vehicles.Select(
                    vehicle => string.Format("{0}{1}Parked at {2}", vehicle.ToString(),
                    Environment.NewLine,
                    Data.ParkedCars[vehicle])));
        }
        

        private void ValidateParameters(IVehicle vehicle, int sector, int placesPerSector, DateTime enterTime)
        {
            if (sector > layout.Sectors)
            {
                throw new ArgumentException(string.Format("There is no sector {0} in the park", sector));
            }

            if (placesPerSector > layout.Places)
            {
                throw new ArgumentException(string.Format("There is no place {0} in sector {1}", placesPerSector, sector));
            }

            if (Data.park.ContainsKey(string.Format("({0},{1})", sector, placesPerSector)))
            {
                throw new ArgumentException(string.Format("The place ({0},{1}) is occupied", sector, placesPerSector));
            }

            if (Data.VehiclesByLicensePlate.ContainsKey(vehicle.LicensePlate))
            {
                throw new ArgumentException(string.Format("There is already a vehicle with license plate {0} in the park", vehicle.LicensePlate));
            }
        }
    }
}
