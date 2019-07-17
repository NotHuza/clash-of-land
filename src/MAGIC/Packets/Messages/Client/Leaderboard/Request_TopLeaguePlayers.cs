using System.IO;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Leaderboard;

namespace ClashLand.Packets.Messages.Client.Leaderboard
{
    // Packet 14503
    internal class Request_TopLeaguePlayers : Message
    {
        public Request_TopLeaguePlayers(Device device) : base(device)
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