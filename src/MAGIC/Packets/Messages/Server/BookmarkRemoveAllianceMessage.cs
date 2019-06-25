/*using System.Collections.Generic;

namespace ClashLand.Packets.Messages.Server
{
    // Packet 24344
    internal class BookmarkRemoveAllianceMessage : Message
    {
        public BookmarkRemoveAllianceMessage(Packets.Client client) : base(client)
        {
            SetMessageType(24344);
        }

        public override void Encode()
        {
            var data = new List<byte>();
            data.Add(1);
            Encrypt(data.ToArray());
        }
    }
}*/