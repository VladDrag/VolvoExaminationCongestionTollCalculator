using System;
using System.Collections.Generic;
using System.Text;

namespace congestion.calculator.Models
{
	public class Diplomat : Vehicle
	{
		public Diplomat()
		{
			Name = "Diplomat";
		}
		public string Name { get; set; }
		public string GetVehicleType() => Name;
	}
}
