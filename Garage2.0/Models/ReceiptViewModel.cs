using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class ReceiptViewModel
    {
        public string RegNr{ get; set; }
        public string CheckInTime { get; set; }
        public double Price { get; set; }
        public string CheckOutTime { get; set; }
    }
}