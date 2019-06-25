using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Clans.War;

namespace ClashLand.Packets.Messages.Client.Clans.War
{
    internal class Request_War_Home_Data : Message
    {
        public Request_War_Home_Data(Device device) : base(device)
        {

        }

        internal override void Process()
        {
            new Visit_War_Player(this.Device).Send();
        }
    }
}
