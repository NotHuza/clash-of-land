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
        internal static Stopwatch Stopwatch = Stopwatch.StartNew();
        public static Stopwatch _Stopwatch = new Stopwatch();

        public static string Version { get; set; }

        internal static void Main()
        {
            Console.Title = $"Clash Land V{Constants.Version} - Developer - {DateTime.Now.Year} ©";
            NativeCalls.SetWindowLong(NativeCalls.GetConsoleWindow(), -20, (int)NativeCalls.GetWindowLong(NativeCalls.GetConsoleWindow(), -20) ^ 0x80000);
            NativeCalls.SetLayeredWindowAttributes(NativeCalls.GetConsoleWindow(), 0, 217, 0x2);

            Console.SetOut(new Prefixed());
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            ClashLand.Core.Consoles.Colorful.Console.WriteWithGradient(@"

               _________ .__                .__     .____                       .___
               \_   ___ \|  | _____    _____|  |__  |    |   _____    ____    __| _/
               /    \  \/|  | \__  \  /  ___/  |  \ |    |   \__  \  /    \  / __ |
               \     \___|  |__/ __ \_\___ \|   Y  \|    |___ / __ \|   |  \/ /_/ | 
                \______  /____(____  /____  >___|  /|_______ (____  /___|  /\____ | 
                       \/          \/     \/     \/         \/    \/     \/      \/       
        
                        Version 9.256 Support (+ v11.x mod)
            ", Color.Yellow, Color.Fuchsia, 14);



            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"ClashLand is protected by our policies, available only to our partner.");
            Console.WriteLine(@"ClashLand program is under the 'Proprietary' license.");
            Console.WriteLine(@"ClashLand is NOT affiliated to 'Supercell Oy'.");
            Console.WriteLine(@"-----------------------------------------------------");
            Console.ResetColor();

            Loger.Say();

            Version = VersionChecker.GetVersionString();
            _Stopwatch.Start();

            if (Version == Constants.Version)

            {
                Console.WriteLine($"> Clash Land is up-to-date: {Constants.Version}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Loger.Say();
                Loger.Say("Preparing Server...\n");
                Resources.Initialize();
            }
            else if (Version == "Error")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("> An Error occured when requesting the Version number.");
                Console.WriteLine();
                Loger.Say();
                Loger.Say("Aborting...");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"> Clash Land is not up-to-date! New Version: {Version}. Aborting...");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
    }
}
