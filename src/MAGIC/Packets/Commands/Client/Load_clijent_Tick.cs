using ClashLand.Extensions.Binary;
using ClashLand.Logic;

namespace ClashLand.Packets
{
    internal class Load_clijent_Tick : Command
    {
        public Load_clijent_Tick(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
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
