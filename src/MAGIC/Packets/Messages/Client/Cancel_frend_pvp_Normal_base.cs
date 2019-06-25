using ClashLand.Extensions.Binary;
using ClashLand.Logic;

namespace ClashLand.Packets
{
    internal class Cancel_frend_pvp_Normal_base : Message
    {
        public Cancel_frend_pvp_Normal_base(Device Device, Reader Reader) : base(Device, Reader)
        {

        }

        internal override void Decode()
        {
            this.Debug();
        }

        internal override void Process()
        {
            
        }
    }
}