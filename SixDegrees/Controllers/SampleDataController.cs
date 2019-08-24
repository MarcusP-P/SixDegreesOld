namespace SixDegrees.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SixDegrees.ResourceModels;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Controller to return API Endpoints
    /// </summary>
    [Route("api/[controller]")]
    public class SampleDataController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Return the fake weather for the next 5 days
        /// </summary>
        /// <returns>soem fake weather for the next 5 days</returns>
        [HttpGet("[action]")]
#pragma warning disable CA1822 // Mark members as static
        public IEnumerable<WeatherForecast> WeatherForecasts()
#pragma warning restore CA1822 // Mark members as static
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d", CultureInfo.InvariantCulture),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

    }
}
