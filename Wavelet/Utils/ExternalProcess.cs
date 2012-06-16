using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wavelet.Utils
{
    using System.Diagnostics;

    using NLog;

    internal class ExternalProcess
    {
        /// <summary>
        /// Logger instance.
        /// </summary>
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Executes the ASCII generator.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        private static void ExecuteExternalApp(TimeSpan timeout, string argumentFilePath)
        {
            var psi = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "SmartProgram.exe",
                Arguments = argumentFilePath
            };

            try
            {
                using (var proc = Process.Start(psi))
                {
                    proc.WaitForExit((int)timeout.TotalMilliseconds);
                }

                var success = true;
                //TODO: check for correct process execution here...

                if (success == false)
                {
                    throw new ApplicationException("External program failed!");
                }
            }
            catch (TimeoutException tex)
            {
                Logger.ErrorException("Timeout", tex);
                // TODO: set main form status label error text
            }
            catch (Exception ex)
            {
                Logger.ErrorException("Error", ex);
                // TODO: set main form status label error text
            }
        }
    }
}
