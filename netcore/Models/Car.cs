using System;
using System.Collections.Generic;
using System.Text;

namespace congestion.calculator.Models
{
    public class Car : Vehicle
    {
        public Car()
        {
            Name = "Car";
        }
        public string Name { get; set; }
        public string GetVehicleType() => Name;
    }
}