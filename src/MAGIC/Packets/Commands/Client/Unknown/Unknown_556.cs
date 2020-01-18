using ClashLand.Logic;
using ClashLand.Extensions.Binary;


namespace ClashLand.Packets.Commands.Client.Unknown
{
    

    internal class Unknown_556 : Command
    {
        public Unknown_556(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

            public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Reader.ReadInt32();
            this.Reader.ReadInt32();
            this.Reader.ReadInt32();
            base.Decode();
        }
    }
}