using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;

namespace Sparky.Core.Logging
{
    public class LogConfiguration
    {
        public static LoggingConfiguration Create()
        {
            var config = new LoggingConfiguration();

            // Define targets
            var targetBlackHole = new NullTarget
            {
                Name = "BlackHole"
            };

            var targetConsole = new ColoredConsoleTarget
            {
                Name = "Console",
                Layout = Layout.FromString("${longdate} ${pad:padding=5:inner=${level:uppercase=true}} ${message} ${exception:format=tostring}"),
                UseDefaultRowHighlightingRules = true,
                ErrorStream = false
            };

            // Define rules
            var ruleMicrosoft = new LoggingRule("Microsoft.*", LogLevel.Debug, LogLevel.Info, targetBlackHole)
            {
                Final = true
            };

            var ruleEverything = new LoggingRule("*", LogLevel.Debug, LogLevel.Fatal, targetConsole);

            // Register.
            config.AddTarget(targetBlackHole);
            config.AddTarget(targetConsole);

            config.LoggingRules.Add(ruleMicrosoft);
            config.LoggingRules.Add(ruleEverything);
            
            return config;
        }
    }
}