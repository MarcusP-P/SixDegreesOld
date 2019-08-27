// <copyright file="SampleDataController.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>

namespace SixDegrees.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SixDegrees.ResourceModels;

    /// <summary>
    /// Controller to return API Endpoints.
    /// </summary>
    [Route("api/[controller]")]
    public class SampleDataController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching",
        };

        /// <summary>
        /// Return the fake weather for the next 5 days.
        /// </summary>
        /// <returns>Fake weather for the next 5 days.</returns>
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
                Summary = Summaries[rng.Next(Summaries.Length)],
            });
        }
    }
}
