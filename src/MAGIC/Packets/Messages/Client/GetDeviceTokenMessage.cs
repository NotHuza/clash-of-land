using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;

namespace ClashLand.Packets.Messages.Client
{
    // Packet 10113
    internal class GetDeviceTokenMessage : Message
    {
        private string Password;

        public GetDeviceTokenMessage(Device Device) : base(Device)
    {

    }

    public GetDeviceTokenMessage(Device Device, Reader Reader) : base(Device, Reader)
    {
    //GetDeviceTokenMessage
    }

    internal override void Decode()
    {
        this.Password = this.Reader.ReadString();
    }

        internal override void Process()
        {
            //this.Device.Player.Password = this.Password;
        }
    }
}