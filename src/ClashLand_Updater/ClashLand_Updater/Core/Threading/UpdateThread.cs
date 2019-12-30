using System.Threading;

namespace ClashLand_Updater.Core.Threading
{
    internal class UpdateThread
    {
        static Thread T { get; set; }

        internal static void Start()
        {

            T = new Thread(() =>
            {
                Update.Updater.DownloadUpdate();
            });
            T.Start();
        }
    }
}
