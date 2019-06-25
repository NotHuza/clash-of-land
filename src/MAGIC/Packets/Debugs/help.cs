using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Extensions;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Packets.Messages.Server;
using ClashLand.Core.Networking;

namespace ClashLand.Packets.Debugs
{
    internal class help : Debug
    {
        internal StringBuilder Help;
        public help(Device device, params string[] Parameters) : base(device, Parameters)
        {

        }
        internal override void Process()
        {
            this.Help = new StringBuilder();
			this.Help.AppendLine("Welcome to Clashology Private Servers");
            this.Help.AppendLine("/refill: upgrading the amount of resources");
            this.Help.AppendLine("/stats: get your account info");
            this.Help.AppendLine("/max_village: upgrade villages to max level");
            this.Help.AppendLine("/rank: {user_id} {rank} (Admins Only)");
            this.Help.AppendLine("/clone: {user_id} copy a players base");
            foreach (var _Device in Devices._Devices.Values.ToList())
            {
                new Global_Chat_Entry(_Device)
                {
                    Message = Help.ToString(),
                    Message_Sender = this.Device.Player.Avatar,
                    Bot = true
                }.Send();
			}
        }
    }
}
