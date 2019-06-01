using ClashLand.Logic.Enums;
using ClashLand.Logic.Structure;
using System.Reflection;

namespace ClashLand.Extensions
{
    internal class Constants
    {
        internal const int ID = 0;
        internal const int MaxCommand  = 0;
        internal const int Buffer = 4096;
        internal const int PRE_ALLOC_SEA = 4096;
        internal const bool Local = false;
        internal const bool PacketCompression = true;
        internal const bool UseSentry = false;
        internal const bool RC4 = true;
        internal const DBMS database = DBMS.Both;
        public static string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        internal static int MaintenanceDuration = 0;
        internal static Maintenance_Timer Maintenance = null;
        internal static readonly string PatchServer = Utils.ParseConfigString("PatchUrl");
        internal static readonly DBMS Database = (DBMS)Utils.ParseConfigInt("DatabaseMode");
        internal static readonly string UpdateServer = Utils.ParseConfigString("UpdateUrl");
        internal static readonly string[] ClientVersion = Utils.ParseConfigString("ClientVersion").Split('.');
        internal static readonly string Events = Utils.ParseConfigString("EventsUrl");

        internal static string[] AuthorizedIP =
        {
            "192.168.0.18",
            "192.168.0.144",
            "115.133.41.158"
        };

        //internal static DBMS Database => database;

        //public static bool Database { get; internal set; }
        //internal static readonly DBMS Database = (DBMS)Utils.ParseConfigInt("DatabaseMode");
    }
}
