using System.Collections.Generic;

namespace UCS.PacketProcessing.Messages.Server
{
    // Packet 24343
    internal class BookmarkAddAllianceMessage : Message
    {
        public BookmarkAddAllianceMessage(PacketProcessing.Client client) : base(client)
        {
            SetMessageType(24343);
        }

        public override void Encode()
        {
            var data = new List<byte>();
            data.Add(1);
            Encrypt(data.ToArray());
        }
    }
}