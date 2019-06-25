using System.Collections.Generic;
using System.Linq;
using ClashLand.Extensions;
using ClashLand.Extensions.List;
using ClashLand.External.Sodium;
using ClashLand.Logic;
using ClashLand.Logic.Enums;

namespace ClashLand.Packets.Messages.Server.Authentication
{
    internal class Unlock_Account_Failed : Message
    {
        internal UnlockReason Reason;
        internal Unlock_Account_Failed(Device Device) : base(Device)
        {
            this.Identifier = 20133;
            this.Version = 1;
        }

        internal override void Encode()
        {
            this.Data.AddInt((int)this.Reason);
        }
    }
}
