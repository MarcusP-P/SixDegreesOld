namespace SixDegrees
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Program startup
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Start the program
        /// </summary>
        /// <param name="args">Array of commandline arguments</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create the webhost
        /// </summary>
        /// <param name="args">Commandline Arguments</param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
