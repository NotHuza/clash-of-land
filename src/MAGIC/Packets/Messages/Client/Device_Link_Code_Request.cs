using System;
using ClashLand.Core;
using ClashLand.Logic;
using ClashLand.Extensions.Binary;
using ClashLand.Core.Networking;
using ClashLand.Packets.Messages.Server;


namespace ClashLand.Packets.Messages.Client
{   

    internal class Device_Link_Code_Request : Message
    {
        public Device_Link_Code_Request(Device Device, Reader Reader) : base(Device, Reader)
        {
            // Device_Link_Code_Request.
        }
    }
}