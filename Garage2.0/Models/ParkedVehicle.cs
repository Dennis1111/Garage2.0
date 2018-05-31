using System;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public String RegistrationNumber { get; set; }
        public String Color { get; set; }
        public String Brand { get; set; }
        public int Wheels { get; set; }
        [Display(Name = "Parked at time")]
        public DateTime Timestamp { get; set; }
    }
}