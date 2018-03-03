using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using Sparky.Core.Logging;

namespace Sparky
{
    public class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            LogManager.Configuration = LogConfiguration.Create();
            LogManager.ReconfigExistingLoggers();

            try
            {
                logger.Debug("Starting Sparky");

                BuildWebHost(args).Run();
            }
            catch (Exception e)
            {
                logger.Error(e, "Exiting Sparky because of an exception");
                throw;
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(builder =>
                {
                    builder.ClearProviders();
                    builder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                })
                .UseNLog()
                .Build();
    }
}
