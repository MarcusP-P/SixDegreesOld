// <copyright file="WeatherForecast.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>

namespace SixDegrees.ResourceModels
{
    /// <summary>
    /// the Weather DTO object.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets Formatted date as a string.
        /// </summary>
        public string DateFormatted { get; set; }

        /// <summary>
        /// Gets or sets the temperature in Celcius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets or sets the description of the weather.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets the calculated temperature in Farenheit.
        /// </summary>
        public int TemperatureF
        {
            get
            {
                return 32 + (int)(this.TemperatureC / 0.5556);
            }
        }
    }
}
