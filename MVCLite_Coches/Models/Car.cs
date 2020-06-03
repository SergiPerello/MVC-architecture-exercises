using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLite_Coches.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Cylinders { get; set; }
        public string LicensePlate { get; set; }
    }
}
