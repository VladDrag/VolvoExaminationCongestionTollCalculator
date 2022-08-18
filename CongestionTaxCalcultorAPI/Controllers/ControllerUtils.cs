using System.Collections.Generic;
using System.Globalization;
using System;
using congestion.calculator.Models;

namespace CongestionTaxCalcultorAPI.Controllers
{
    public class ControllerUtils
	{
		public string TaxCalc(Vehicle vehicle, DateTime[] time)
		{
			CongestionTaxCalculator calc = new CongestionTaxCalculator();

			var calculatedTax = calc.GetTax(vehicle, time);
			return calculatedTax.ToString();
		}

		public Vehicle DetectVehicle(string vehicleName)
		{
			if (string.IsNullOrEmpty(vehicleName)) return null;

			if (vehicleName == "motorcycle") return new Motorcycle();

			if (vehicleName == "car") return new Car();

			return null;
		}

		public DateTime[] CreateTimeInterval(string[] timeStrings)
		{
			Console.WriteLine(timeStrings[0]);
			var result = new List<DateTime> { };
			CultureInfo culture = new CultureInfo("en-US");

			foreach (var timeString in timeStrings)
			{
				result.Add(Convert.ToDateTime(timeString, culture));
			}
			return result.ToArray();
		}
	}
}
