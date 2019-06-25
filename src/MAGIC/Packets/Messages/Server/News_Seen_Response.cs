using ClashLand.Extensions.List;
using ClashLand.Logic;

namespace ClashLand.Packets.Messages.Server
{
    internal class News_Seen_Response : Message
    {
        internal News_Seen_Response(Device Device) : base(Device)
        {
            this.Identifier = 24445;
        }

        internal override void Encode()
        {
            this.Data.AddInt(0);
        }
    }
}
