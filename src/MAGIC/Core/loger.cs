using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashLand.Core
{
    class Loger
    {
        public static void Say(string message, bool write = false)
        {
            if (!write)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ResetColor();
                Console.WriteLine(message);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ResetColor();
                Console.Write(message);
            }
        }

        public static void Say()
        {
            Console.WriteLine();
        }
    }
}
