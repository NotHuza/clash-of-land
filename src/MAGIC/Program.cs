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
using System.Timers;
using System.Drawing;

namespace ClashLand
{
    internal class Program
    {
        private static int Width = 120;
        private static int Height = 30;
        public static string Version { get; set; }

        internal static Stopwatch Stopwatch = Stopwatch.StartNew();
        public static Stopwatch _Stopwatch = new Stopwatch();

        internal static void Main()
        {
            Console.Title = $"ClashLand Server V{Constants.Version} - Developer - {DateTime.Now.Year} ©";
            NativeCalls.SetWindowLong(NativeCalls.GetConsoleWindow(), -20, (int)NativeCalls.GetWindowLong(NativeCalls.GetConsoleWindow(), -20) ^ 0x80000);
            NativeCalls.SetLayeredWindowAttributes(NativeCalls.GetConsoleWindow(), 0, 217, 0x2);

            Core.Consoles.Colorful.Console.SetOut(new Prefixed());

            Console.SetWindowSize(Program.Width, Program.Height);

            Core.Consoles.Colorful.Console.SetBufferSize(Core.Consoles.Colorful.Console.WindowWidth, Core.Consoles.Colorful.Console.WindowHeight);

            Core.Consoles.Colorful.Console.WriteWithGradient(@"






                        _________ .__                .__     .____                       .___
                        \_   ___ \|  | _____    _____|  |__  |    |   _____    ____    __| _/
                        /    \  \/|  | \__  \  /  ___/  |  \ |    |   \__  \  /    \  / __ |
                        \     \___|  |__/ __ \_\___ \|   Y  \|    |___ / __ \|   |  \/ /_/ | 
                         \______  /____(____  /____  >___|  /|_______ (____  /___|  /\____ | 
                                \/          \/     \/     \/         \/    \/     \/      \/ 
                                               Version 9.256 Support (+ v10.134 mod)
            ", Color.OrangeRed, Color.LimeGreen, 14);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"ClashLand is protected by our policies, available only to our partner.");
            Console.WriteLine(@"ClashLand program is under the 'Proprietary' license.");
            Console.WriteLine(@"ClashLand is NOT affiliated to 'Supercell Oy'.");
            Console.WriteLine(@"-----------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Name + @" is now starting..." + Environment.NewLine);

            Resources.Initialize();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"-------------------------------------" + Environment.NewLine);

            Thread.Sleep(Timeout.Infinite);
        }
    }
}