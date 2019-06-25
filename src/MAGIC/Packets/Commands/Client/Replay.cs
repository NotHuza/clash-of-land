using ClashLand.Logic;
using ClashLand.Extensions.Binary;

namespace ClashLand.Packets.Commands.Client
{
     

    internal class Replay : Command
    {
        public Replay(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
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
