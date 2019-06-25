using ClashLand.Logic;
using ClashLand.Extensions.Binary;

namespace ClashLand.Packets.Messages.Client
{
    
    internal class Device_Link_Enter_Code : Message
    {
        private string Code;

        public Device_Link_Enter_Code(Device Device, Reader Reader) : base(Device, Reader)
        {
            // DeliveLinkEnterCode.
        }

        internal override void Decode()
        {
            this.Code = this.Reader.ReadString();
        }
    }
}