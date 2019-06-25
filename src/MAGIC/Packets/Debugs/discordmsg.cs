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
    internal class discordmsg : Debug
    {
        internal StringBuilder Discordmsg;
        public discordmsg(Device device, params string[] Parameters) : base(device, Parameters)
        {

        }
        internal override void Process()
        {
            if (this.Device.Player.Avatar.Rank >= Rank.ADMIN)
                try
                {
                    this.Discordmsg = new StringBuilder();
			        this.Discordmsg.AppendLine("Welcome To Clashology Private Servers");
                    this.Discordmsg.AppendLine("Come Checkout Our Discord!");
                    this.Discordmsg.AppendLine("https://discord.gg/jWbWwMW");
                    this.Discordmsg.AppendLine("Chat With Other Players And Members ヅ");
                    //this.Discordmsg.AppendLine("");
                    //this.Discordmsg.AppendLine("****************");
                    foreach (var _Device in Devices._Devices.Values.ToList())
                    {
                        new Global_Chat_Entry(_Device)
                        {
                            Message = Discordmsg.ToString(),
                            Message_Sender = this.Device.Player.Avatar,
                            Bot = true
                        }.Send();
                    }
			}
            catch (Exception)
                {
                    SendChatMessage("Command Processor: Insufficient privileges.");
                }
        }
    }
}