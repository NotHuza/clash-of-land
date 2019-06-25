using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server;
using ClashLand.Packets.Messages.Server.Clans;

namespace ClashLand.Packets.Messages.Client
{
    internal class Ask_Visit_Home : Message
    {
        internal long AvatarId;

        public Ask_Visit_Home(Device device) : base(device)
        {
        }

        internal override void Decode()
        {
            this.AvatarId = this.Reader.ReadInt64();
        }

        internal override void Process()
        {
            var target = Players.Get(this.AvatarId, false);
            if (target != null)
            {
                new Visit_Home_Data(this.Device, target).Send();

                if (this.Device.Player.Avatar.ClanId > 0)
                {
                    new Alliance_All_Stream_Entry(this.Device).Send();
                }
            }
            else
                new Own_Home_Data(this.Device).Send();
        }
    }
}
