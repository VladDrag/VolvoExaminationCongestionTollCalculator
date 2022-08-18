using System;
using System.Collections.Generic;
using System.Text;

namespace congestion.calculator.Models
{
	public class Military : Vehicle
	{
		public Military()
		{
			Name = "Military";
		}
		public string Name { get; set; }
		public string GetVehicleType() => Name;
	}
}
