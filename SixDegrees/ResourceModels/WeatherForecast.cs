namespace SixDegrees.ResourceModels
{
    /// <summary>
    /// the Weather DTO object
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Formatted date as a string
        /// </summary>
        public string DateFormatted { get; set; }

        /// <summary>
        /// Temperature in Celcius
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Description of the weather
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Calculated temperature in Farenheit
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
