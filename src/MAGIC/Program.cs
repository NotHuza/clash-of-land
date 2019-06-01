using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Extensions;
using System.Threading;
using ClashLand.Core.Networking;
using ClashLand.Extensions.List;
using ClashLand.core.Checker;
using System.Timers;
using System.Drawing;

namespace ClashLand
{
    internal class Program
    {
        public static string Version { get; set; }
        internal static Stopwatch Stopwatch = Stopwatch.StartNew();
        public static Stopwatch _Stopwatch = new Stopwatch();

        internal static void Main()
        {
            //Console.Title = $"ClashLand Server V{Constants.Version} - Developer - {DateTime.Now.Year} ©";
            Console.Title = $"[ClashLand Server] {Assembly.GetExecutingAssembly().GetName().Name} - Developer - {DateTime.Now.Year} ©";
            //Console.Title = $"ClashLand Server v{Constants.Version} - ©ClashLand";
            NativeCalls.SetWindowLong(NativeCalls.GetConsoleWindow(), -20, (int)NativeCalls.GetWindowLong(NativeCalls.GetConsoleWindow(), -20) ^ 0x80000);
            NativeCalls.SetLayeredWindowAttributes(NativeCalls.GetConsoleWindow(), 0, 217, 0x2);

            Console.SetOut(new Prefixed());
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Core.Consoles.Colorful.Console.WriteWithGradient(@"






         _________ .__                .__     .____                       .___
         \_   ___ \|  | _____    _____|  |__  |    |   _____    ____    __| _/
         /    \  \/|  | \__  \  /  ___/  |  \ |    |   \__  \  /    \  / __ |
         \     \___|  |__/ __ \_\___ \|   Y  \|    |___ / __ \|   |  \/ /_/ | 
          \______  /____(____  /____  >___|  /|_______ (____  /___|  /\____ | 
                  \/          \/     \/     \/         \/    \/     \/      \/ 
                         Version 9.256 Support (+ v10.134 mod)
            ", Color.Yellow, Color.Fuchsia, 14);
            //Console.ForegroundColor = ConsoleColor.DarkYellow;

            /*(@"_________ .__                .__     .____                       .___");
            Console.WriteLine(@"\_   ___ \|  | _____    _____|  |__  |    |   _____    ____    __| _/");
            Console.WriteLine(@"/    \  \/|  | \__  \  /  ___/  |  \ |    |   \__  \  /    \  / __ | ");
            Console.WriteLine(@"\     \___|  |__/ __ \_\___ \|   Y  \|    |___ / __ \|   |  \/ /_/ | ");
            Console.WriteLine(@" \______  /____(____  /____  >___|  /|_______ (____  /___|  /\____ | ");
            Console.WriteLine(@"        \/          \/     \/     \/         \/    \/     \/      \/ ");
            Console.WriteLine(@"                Version 9.256 Support (+ v10.134 mod)                 ");
            Console.ResetColor();*/

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(@"ClashLand is protected by our policies, available only to our partner.");
            Console.WriteLine(@"ClashLand program is under the 'Proprietary' license.");
            Console.WriteLine(@"ClashLand is NOT affiliated to 'Supercell Oy'.");
            Console.WriteLine(@"-----------------------------------------------------");
            //Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;

            //Version = VersionChecker.GetVersionString();
            if (/*Version == Constants.Version*/true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"ClashLand is Up to Date");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Name + @" is now starting now...");
                Console.ResetColor();
                Resources.Initialize();
                Console.WriteLine(@"-----------------------------------------------------" + Environment.NewLine);
            }
            else if (Version == "Error")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"Server Can not Identify Version Please check your Host!");
                Console.WriteLine(@"Server will close automatically in 5 sec...");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if (Version != Constants.Version)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"New ClashLand Server is available!");
                Console.WriteLine(@"Server will update automatically in 5 sec...");
                Thread.Sleep(5000);
                Process.Start(@"..\Debug\Tools\ClashLand_Updater.exe");
                Environment.Exit(0);
            }
                Thread.Sleep(Timeout.Infinite);
        }
    }
}