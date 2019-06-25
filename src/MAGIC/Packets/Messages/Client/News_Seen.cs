using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packets.Messages.Client
{
    internal class News_Seen : Message
    {
        internal int News;

        public News_Seen(Device device) : base(device)
        {
        }

        internal override void Decode()
        {
            this.News = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            new News_Seen_Response(Device).Send();
        }
    }
}