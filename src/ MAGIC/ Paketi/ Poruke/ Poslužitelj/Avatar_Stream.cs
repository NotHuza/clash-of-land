using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Extensions;
using ClashLand.Extensions.List;
using ClashLand.Logic;

namespace ClashLand.Packets.Messages.Server
{
    internal class Avatar_Stream : Message
    {
        internal Player Player = null;

        public Avatar_Stream(Device client) : base(client)
        {
            this.Identifier = 24411;
        }

        internal override void Encode()
        {
            this.Data.AddRange(Player != null ? this.Player.Inbox.ToBytes : this.Device.Player.Avatar.Inbox.ToBytes);
        }
    }
}
