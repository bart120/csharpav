using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venezia.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Mark { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public Fuel FuelType { get; set; }

        public bool Autonomous { get; set; }
    }

    public enum Fuel
    {
        Gasoline,
        Diesel
    }
}
