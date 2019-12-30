using System;
using System.Reflection;
using System.Threading;
using ClashLand_Updater.Extensions;
using static System.Console;

namespace ClashLand_Updater.Core.Threading
{
    internal class ConsoleThread
    {
        static Thread T { get; set; }

        internal static void Start()
        {
            T = new Thread(() =>
            {
                Console.Title = "ClashLand Server - ©ClashLand";
                NativeCalls.SetWindowLong(NativeCalls.GetConsoleWindow(), -20, (int)NativeCalls.GetWindowLong(NativeCalls.GetConsoleWindow(), -20) ^ 0x80000);
                NativeCalls.SetLayeredWindowAttributes(NativeCalls.GetConsoleWindow(), 0, 217, 0x2);

                Console.SetOut(new Prefixed());
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(@"_________ .__                .__     .____                       .___");
                Console.WriteLine(@"\_   ___ \|  | _____    _____|  |__  |    |   _____    ____    __| _/");
                Console.WriteLine(@"/    \  \/|  | \__  \  /  ___/  |  \ |    |   \__  \  /    \  / __ | ");
                Console.WriteLine(@"\     \___|  |__/ __ \_\___ \|   Y  \|    |___ / __ \|   |  \/ /_/ | ");
                Console.WriteLine(@" \______  /____(____  /____  >___|  /|_______ (____  /___|  /\____ | ");
                Console.WriteLine(@"        \/          \/     \/     \/         \/    \/     \/      \/ ");
                Console.WriteLine(@"                    ClashLand Server Updater v1.0                    ");
                Console.ResetColor();

                Console.WriteLine(@"ClashLand is protected by our policies, available only to our partner.");
                Console.WriteLine(@"ClashLand program is under the 'Proprietary' license.");
                Console.WriteLine(@"ClashLand is NOT affiliated to 'Supercell Oy'.");
                Console.WriteLine(@"-----------------------------------------------------");

                CheckerThread.Start();
                //UpdateThread.Start();

                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine(@"ClashLand Server is Updating...");
                ResetColor();
            });
            T.Start();
            ReadLine();
        }
    }
}
