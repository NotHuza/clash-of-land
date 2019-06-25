using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server;


namespace ClashLand.Packets.Messages.Client
{
    internal class Request_Name_Change : Message
    {
        internal string Name;
        public Request_Name_Change(Device device) : base(device)
        {
            // Request_Name_Change.
        }
        internal override void Decode()
        {
            this.Name = this.Reader.ReadString();
        }
        internal override void Process()
        {
            new Name_Change_Response(this.Device, this.Name).Send();
        }
    }
}
