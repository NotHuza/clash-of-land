using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packets.Messages.Client
{
    internal class Avatar_Profile : Message
    {
        internal long UserID;

        public Avatar_Profile(Device device) : base(device)
        {
            // Avatar_Profile.
        }

        internal override void Decode()
        {
            this.UserID = this.Reader.ReadInt64();

            this.Reader.ReadByte();

            this.Reader.ReadInt32(); //HomeId High
            this.Reader.ReadInt32(); //HomeId Low
        }

        internal override void Process()
        {
            new Avatar_Profile_Data(this.Device) {UserID = this.UserID}.Send();
        }
    }

}