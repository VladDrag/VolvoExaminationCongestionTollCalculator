using System.Collections.Generic;
using System.Globalization;
using System;
using congestion.calculator.Models;
using congestion.calculator;

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

			CongestionTaxCalculator calc = new CongestionTaxCalculator();

			if (string.IsNullOrEmpty(vehicleName)) return null;

			if (vehicleName == "car") return new Car();

			if (vehicleName == "motorcycle") return new Motorcycle();

			if (vehicleName == "diplomat") return new Diplomat();

			if (vehicleName == "emergency") return new Emergency();

			if (vehicleName == "foreign") return new Foreign();

			if (vehicleName == "military") return new Military();

			if (vehicleName == "tractor") return new Tractor();

			return null;
		}

		public DateTime[] CreateTimeInterval(string[] timeStrings)
		{
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
