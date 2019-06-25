using ClashLand.Logic;
using ClashLand.Extensions.Binary;

namespace ClashLand.Packets.Commands.Client
{
    
    internal class Troop_Request_Message : Command
    {
        public Troop_Request_Message(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
            
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
