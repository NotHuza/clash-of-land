using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Leaderboard;

namespace ClashLand.Packets.Messages.Client.Leaderboard
{
    internal class Request_Local_Players : Message
    {
        public Request_Local_Players(Device device) : base(device)
        {
        }

        internal override void Process()
        {
            if (this.Device.Player.Avatar.Variables.IsBuilderVillage)
            {

            }
            else
            {
                new Local_Players(this.Device).Send();
            }
        }
    }
}
