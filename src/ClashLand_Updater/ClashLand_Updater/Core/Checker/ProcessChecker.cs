using System.Diagnostics;
using ClashLand_Updater.Core.Threading;

namespace ClashLand_Updater.Core.Checker
{
    class ProcessChecker
    {
        public static void Check()
        {
            Process[] CLSOpen = Process.GetProcessesByName("CLS_2018.exe");
            if (CLSOpen.Length != 0)
            {
                foreach (var Process in Process.GetProcessesByName("CLS_2018.exe"))
                {
                    Process.Kill();
                }
                UpdateThread.Start();
            }
            else if (CLSOpen.Length == 0)
            {
                UpdateThread.Start();
            }
        }
    }
}
