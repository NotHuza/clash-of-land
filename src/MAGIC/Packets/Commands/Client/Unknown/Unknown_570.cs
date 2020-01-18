using ClashLand.Logic;
using ClashLand.Extensions.Binary;


namespace ClashLand.Packets.Commands.Client.Unknown
{

    internal class Unknown_570 : Command
    {
        public Unknown_570(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Reader.ReadInt32();
            base.Decode();
        }
    }
}