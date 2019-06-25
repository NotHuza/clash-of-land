using ClashLand.Extensions.List;
using ClashLand.Logic;

namespace ClashLand.Packets.Messages.Server.Errors
{
    internal class Out_Of_Sync : Message
    {
        public Out_Of_Sync(Device Device) : base(Device)
        {
            this.Identifier = 24104;
        }
        internal override void Encode()
        {
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
        }
    }
}