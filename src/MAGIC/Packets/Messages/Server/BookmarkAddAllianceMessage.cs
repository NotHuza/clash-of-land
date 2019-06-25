/*using ClashLand.Logic;
using System.Collections.Generic;
using ClashLand.Core;
using ClashLand.Packets;

namespace ClashLand.Packets.Messages.Server
{
    // Packet 24343
    internal class BookmarkAddAllianceMessage : Message
    {
        public BookmarkAddAllianceMessage(Packets.Message client) : base(Avatar)
        {
            this.Identifier = (24343);
            this.Message = message;
        }

        internal override void Encode()
        {
            this.Data.AddRange(this.Message.ToBytes);
        }
    }
}*/