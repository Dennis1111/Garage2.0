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
        [StringLength(6, MinimumLength=6)]
        public String RegistrationNumber { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public String Color { get; set; }
        public String Brand { get; set; }
        public int Wheels { get; set; }
        [Display(Name = "Parked at time")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Timestamp { get; set; }
    }
}