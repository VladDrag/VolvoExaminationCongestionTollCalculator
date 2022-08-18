using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator
{
    public class Car : Vehicle
    {
        public Car()
        {
            Name = "Car";
        }
        public string Name { get; set; }
        public String GetVehicleType() => Name;
    }
}