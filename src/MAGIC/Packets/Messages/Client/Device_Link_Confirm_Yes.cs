using ClashLand.Logic;
using ClashLand.Extensions.Binary;

namespace ClashLand.Packets.Messages.Client
{
   
    internal class Device_Link_Confirm_Yes : Message
    {
        
        public Device_Link_Confirm_Yes(Device Device, Reader Reader) : base(Device, Reader)
        {
            // DeviceLinkConfirmYes.
        }
    }
}