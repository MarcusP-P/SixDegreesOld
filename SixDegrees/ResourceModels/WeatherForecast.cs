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
