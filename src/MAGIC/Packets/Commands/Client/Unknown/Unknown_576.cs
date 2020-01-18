namespace ClashLand.Packets.Commands.Client.Unknown
{
    using ClashLand.Logic;
    using ClashLand.Extensions.Binary;

    internal class Unknown_576 : Command
    {
        public Unknown_576(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        /*internal override int Type
        {
            get
            {
                return 576;
            }
        }*/
        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Reader.ReadByte();
            this.Reader.ReadInt32();
            this.Reader.ReadInt32();
            base.Decode();
        }
    }
}