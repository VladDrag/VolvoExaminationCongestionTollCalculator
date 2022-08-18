using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator.Models
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            Name = "Motorcycle";
        }
        public string Name { get; set; }
        public string GetVehicleType() => Name;
    }
}