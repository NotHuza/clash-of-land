using System.Text;
using System.Threading.Tasks;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packets.Messages.Client.Clans
{
    internal class ChallangeWatchLiveMessage : Message
    {
        public ChallangeWatchLiveMessage(Device device, Reader reader) : base(device, reader)
        {
        }

        internal override void Process()
        {
            new Own_Home_Data(this.Device).Send();
        }
    }
}
