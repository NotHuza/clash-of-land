using ClashLand.Core;
using ClashLand.Logic;
using ClashLand.Extensions.Binary;
using ClashLand.Extensions.List;

namespace ClashLand.Packets.Messages.Client.Battle
{

    internal class CancelDuelMatchmakeMessage : Message
    {    
        
        public CancelDuelMatchmakeMessage(Device Device) : base(Device)
        {
            this.Identifier = 14103;
        }

        internal override void Decode()
        {
            this.Debug();
        }



        internal override void Process()
        {
            base.Process();
        }
    }
}