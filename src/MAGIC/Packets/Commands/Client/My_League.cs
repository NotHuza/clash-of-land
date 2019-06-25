using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Leaderboard;

namespace ClashLand.Packets.Commands.Client
{
    internal class My_League : Command
    {
        public My_League(Reader reader, Device client, int id) : base(reader, client, id)
        {

        }

        internal override void Process()
        {
            new League_Players(this.Device).Send();
        }
    }
}
