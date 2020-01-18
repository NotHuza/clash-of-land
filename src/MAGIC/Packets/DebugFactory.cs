using System;
using System.Collections.Generic;
using ClashLand.Packets.Debugs;

namespace ClashLand.Packets
{
    internal class DebugFactory
    {
        internal const string Delimiter = "/";

        public static Dictionary<string, Type> Debugs;

        public DebugFactory()
        {
            Debugs = new Dictionary<string, Type>
            {
                {"resource", typeof(Resource_Update)},
                {"stats", typeof(Statistics)},
                {"max_village", typeof(Max_Village)},
                {"rank", typeof(Set_Rank)},
                {"clone", typeof(Clone_Player)},
                {"help", typeof(help)},
                {"sysmsg", typeof(sysmsg)},
                {"discordmsg", typeof(discordmsg)},
                {"svrstatus", typeof(Server_Status)},
                {"oba", typeof(Own_Base_Attack)}
            };
        }
    }
}