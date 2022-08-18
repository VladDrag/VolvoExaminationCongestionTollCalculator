using System;
using System.Collections.Generic;
using System.Text;

namespace congestion.calculator.Models
{
	public class Foreign : Vehicle
	{
		public Foreign()
		{
			Name = "Foreign";
		}
		public string Name { get; set; }
		public string GetVehicleType() => Name;
	}
}
