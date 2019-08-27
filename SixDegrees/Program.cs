// <copyright file="Program.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>

namespace SixDegrees
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Program startup.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Start the program.
        /// </summary>
        /// <param name="args">Array of commandline arguments.</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create the webhost.
        /// </summary>
        /// <param name="args">Commandline Arguments.</param>
        /// <returns>A Webhost builder to be used to start the host.</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
