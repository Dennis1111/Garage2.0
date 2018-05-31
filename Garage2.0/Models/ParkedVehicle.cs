using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public String RegistrationNumber { get; set; }

        public VehicleType Type { get; set; }
        public String Color { get; set; }
        public String Brand { get; set; }
        public int Wheels { get; set; }
    }
}