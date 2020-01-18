using ClashLand.Logic;
using ClashLand.Extensions.Binary;


namespace ClashLand.Packets.Commands.Client
{
    internal class Clock_Tower_Boost : Command
    {
        internal int Id;

        public Clock_Tower_Boost(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Id = this.Reader.ReadInt32();
            base.Decode();
        }
    }
}