namespace ClashLand.Packets.Commands.Client.Unknown
{
    using ClashLand.Logic;
    using ClashLand.Extensions.Binary;

    internal class Unknown_585 : Command
    {
        public Unknown_585(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Reader.ReadByte();
            this.Reader.ReadInt32();
            base.Decode();
        }
    }
}