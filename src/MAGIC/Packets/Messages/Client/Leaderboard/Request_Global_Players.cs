using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Leaderboard;

namespace ClashLand.Packets.Messages.Client.Leaderboard
{
    internal class Request_Global_Players :Message
    {
        public Request_Global_Players(Device device) : base(device)
        {
        }
        internal override void Process()
        {
            if (this.Device.Player.Avatar.Variables.IsBuilderVillage)
            {
                
            }
            else
            {
                new Global_Players(this.Device).Send();
            }
        }
    }
}
