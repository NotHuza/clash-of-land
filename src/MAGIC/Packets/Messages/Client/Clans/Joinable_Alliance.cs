using ClashLand.Logic;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Packets.Messages.Server.Clans;

namespace ClashLand.Packets.Messages.Client.Clans
{
    internal class Joinable_Alliance : Message
    {
        public Joinable_Alliance(Device Device) : base(Device)
        {

        }

        internal override void Process()
        {
            new Alliance_Joinable_Data(this.Device).Send();
        }
    }
}
