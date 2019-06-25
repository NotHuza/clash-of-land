using System;
using ClashLand.Logic;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;

namespace ClashLand.Packets.Messages.Client
{
   internal class Keep_Alive : Message
    {
        public Keep_Alive(Device Device) : base(Device)
        {
            // Keep_Alive.
        }

        internal override void Process()
        {
            this.Device.LastKeepAlive = DateTime.Now;
            this.Device.NextKeepAlive = this.Device.LastKeepAlive.AddSeconds(30);
            this.Device.Keep_Alive.Send();
        }
    }
}
