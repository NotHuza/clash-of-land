using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packets.Messages.Client.Clans
{
    internal class ChallangeVisitMessage : Message
    {
        public ChallangeVisitMessage(Device device, Reader reader) : base(device, reader)
        {
        }

        public long AvatarID { get; set; }

        internal override void Decode()
        {
            this.AvatarID = this.Reader.ReadInt64();
        }

        internal override void Process()
        {
            new Own_Home_Data(this.Device).Send();
            //var defender = ResourcesManager.GetPlayer(AvatarID); // TODO: FIX BUGS		
            //PacketManager.ProcessOutgoingPacket(new VisitedHomeDataMessage(Client, defender, level)); 
        }
    }
}
