using System.Threading;
using ClashLand_Updater.Core.Checker;

namespace ClashLand_Updater.Core.Threading
{
    internal class CheckerThread
    {
        static Thread T { get; set; }

        internal static void Start()
        {

            T = new Thread(() =>
            {
                ProcessChecker.Check();
            });
            T.Start();
        }
    }
}
