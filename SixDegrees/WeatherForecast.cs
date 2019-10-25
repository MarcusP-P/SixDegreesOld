// <copyright file="WeatherForecast.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>

namespace SixDegrees
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
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the temperature in Celcius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets the calculated temperature in Farenheit.
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets the description of the weather.
        /// </summary>
        public string Summary { get; set; }
    }
}
