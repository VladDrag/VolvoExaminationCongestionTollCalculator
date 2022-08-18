using System;
using System.Collections.Generic;
using System.Text;

namespace congestion.calculator.Models
{
	public class Emergency : Vehicle
	{
		public Emergency()
		{
			Name = "Emergency";
		}
		public string Name { get; set; }
		public string GetVehicleType() => Name;
	}
}
