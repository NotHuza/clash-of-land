using ClashLand.Logic;
using ClashLand.Extensions.List;



namespace ClashLand.Packets.Messages.Server
{

    internal class WaitingToGoHomeMessage : Message
    {
        internal int EstimatedTime;

        internal WaitingToGoHomeMessage(Device device, int estimatedTime) : base(device)
        {
            this.EstimatedTime = estimatedTime;
            this.Identifier = 24112;
        }


        internal override void Encode()
        {
            this.Data.AddInt(this.EstimatedTime);
        }
    }
}