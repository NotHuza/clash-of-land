using ClashLand.Logic;
using ClashLand.Extensions.Binary;


namespace ClashLand.Packets.Commands.Client.Unknown
{

    internal class Unknown_581 : Command
    {
        internal int Count;
                
        public Unknown_581(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
            //Seems to be war related
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Count = this.Reader.ReadInt32();

            for (int i = 0; i < this.Count; i++)
            {
                this.Reader.ReadInt64();
            }

            this.Reader.ReadInt64();
            this.Reader.ReadInt32();
            this.Reader.ReadInt32();
            this.Reader.ReadInt32();
            base.Decode();
        }
    }
}