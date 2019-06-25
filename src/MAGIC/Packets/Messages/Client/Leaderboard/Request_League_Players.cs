using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Leaderboard;

namespace ClashLand.Packets.Messages.Client.Leaderboard
{
    internal class Request_League_Players : Message
    { 
        public Request_League_Players(Device device) : base(device)
        {
        }

        internal override void Decode()
        {
        }

        internal override void Process()
        {
            new League_Players(this.Device).Send();
        }
    }
}
