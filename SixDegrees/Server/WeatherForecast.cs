// <copyright file="WeatherForecast.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>
// Contains the WetherForecast class, which is the DTO for returnign the weather.
// </summary>

namespace SixDegrees.Server
{
    using System;

    /// <summary>
    /// the Weather DTO object.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecast"/> class.
        /// </summary>
        /// <param name="date">Date of the forecast.</param>
        /// <param name="temperatureC">The Temperature, in Celcius.</param>
        /// <param name="summary">Description of the weather.</param>
        public WeatherForecast(DateTime date, int temperatureC, string summary)
        {
            this.Date = date;
            this.TemperatureC = temperatureC;
            this.Summary = summary;
        }

        /// <summary>
        /// Gets or sets the date of the forecast.
        /// </summary>
        /// <value>
        /// The date of the forecast.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the temperature in Celcius.
        /// </summary>
        /// <value>
        /// The temperature in Celcius.
        /// </value>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets the calculated temperature in Farenheit.
        /// </summary>
        /// <value>
        /// The calculated temperature in Farenheit.
        /// </value>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets the description of the weather.
        /// </summary>
        /// <value>
        /// The description of the weather.
        /// </value>
        public string Summary { get; set; }
    }
}
