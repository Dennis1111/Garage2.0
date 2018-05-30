using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public enum VehicleType
    {
        Car,
        MotorCycle,
        Boat,
        Airplane,
        Bus
    }

    public class ParkedVehicle
    {    
        public VehicleType Type { get; set; }
        public String RegistrationNumber { get; set; }
        public String Color { get; set; }
        public String Brand { get; set; }
        public int Wheels { get; set; }
    }
}