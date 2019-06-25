namespace ClashLand.Packets.Commands.Client
{
    using ClashLand.Logic;
    using ClashLand.Extensions.Binary;

    internal class ShieldCostSeen : Command
    {
        public ShieldCostSeen(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
            
        }

        internal override void Decode()
        {
            this.Reader.ReadInt32();
            this.Reader.ReadByte();

            this.Reader.ReadInt32();
        }

        internal override void Process()
        {
        }
    }
}
