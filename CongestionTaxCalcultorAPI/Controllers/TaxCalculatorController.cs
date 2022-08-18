using Microsoft.AspNetCore.Mvc;
using congestion.calculator;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Globalization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CongestionTaxCalcultorAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TaxCalculatorController : ControllerBase
	{
		private ControllerUtils _controllerUtils = new ControllerUtils();

		[HttpPost("{vehicleName}/{timeInterval}")]
		public async Task<ActionResult<string>> Post([FromRoute] string vehicleName, [FromRoute] string[] timeInterval)
		{
			var timeStrings = timeInterval[0].Split(",");

			var time = _controllerUtils.CreateTimeInterval(timeStrings);
			var vehicle = _controllerUtils.DetectVehicle(vehicleName.ToLower());
			var result = _controllerUtils.TaxCalc(vehicle, time.ToArray());
			return Ok(result);
		}

	}
}
