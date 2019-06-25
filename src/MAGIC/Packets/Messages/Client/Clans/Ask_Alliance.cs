using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Clans;

namespace ClashLand.Packets.Messages.Client.Clans
{
    internal class Ask_Alliance : Message
    {
        internal long ClanID;

        public Ask_Alliance(Device device) : base(device)
        {

        }

        internal override void Decode()
        {
            this.ClanID = this.Reader.ReadInt64();
        }

        internal override void Process()
        {
            new Alliance_Data(this.Device) {Clan = Resources.Clans.Get(this.ClanID)}.Send();
        }
    }
}