using ClashLand.Logic;
using ClashLand.Extensions.Binary;


namespace ClashLand.Packets.Commands.Client.Unknown
{

    internal class Unknown_566 : Command
    {
        public Unknown_566(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
        }
    }
}