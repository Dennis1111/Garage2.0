using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Garage2._0.Models;

namespace Garage2._0.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
       public DbSet<ParkedVehicle> ParkedVehicles { get; set; }

        public RegisterContext():base ("DefaultConnection")
        {
        }
    }
}