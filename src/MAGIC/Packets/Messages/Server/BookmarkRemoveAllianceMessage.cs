using System.Collections.Generic;
using System.Threading.Tasks;
using ClashLand.Extensions.List;
using ClashLand.Core;
using ClashLand.Files;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots;

namespace ClashLand.Packets.Messages.Server
{
    // Packet 24344
    internal class BookmarkRemoveAllianceMessage : Message
    {
        public BookmarkRemoveAllianceMessage(Device client) : base(client)
        {
            //SetMessageType(24344);
            Identifier = 24344;
        }

        /*public override void Encode()
        {
            var data = new List<byte>();
            data.Add(1);
            Encrypt(data.ToArray());
        }*/
    }
}