using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using NLog.Config;
using NLog.Targets;
using Valax321.DialogueEditor.Forms;

namespace Valax321.DialogueEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new LoggingConfiguration();
#if DEBUG
            var logDebugger = new DebuggerTarget("logdebugger")
            {
                Layout = "[${callsite-filename}:${callsite-linenumber}] ${level:uppercase=true}: ${message}"
            };

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logDebugger);
#endif

            var logFile = new FileTarget("logfile")
            {
                FileName = "${basedir}/DialogueEditor.log", 
                Layout = "[${longdate}] [${logger}] [${level:uppercase=true}] ${message}"
            };
            config.AddRule(LogLevel.Warn, LogLevel.Fatal, logFile);

            LogManager.Setup()
                .SetupExtensions(s => s.AutoLoadAssemblies(false))
                .LoadConfiguration(config);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectForm());
        }
    }
}
