using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public enum Type
    {
        CAR, MC, EMTYP
    }
    public class Vehicle : IEntity
    {
        public Vehicle()
        {

        }
        public Vehicle(string licensePlate)
        {
            this.LicensePlate = licensePlate;
        }
        public string LicensePlate { get; }
        public int SpotNumber { get; set; }
        public int OldSpotNumber { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int VehicleTypeId { get; set; }
        public TimeSpan ParkedTime { get; set; }
        public decimal CostByHour { get; set; }
        public decimal TotalCost { get; set; }
        public Type VehicleType
        {
            get
            {
                if (VehicleTypeId == 1)
                {
                    return Type.CAR;
                }
                if (VehicleTypeId == 2)
                {
                    return Type.MC;
                }
                return Type.EMTYP;
            }
            set 
            {
                VehicleType = value;
            }

        }
    }
}
