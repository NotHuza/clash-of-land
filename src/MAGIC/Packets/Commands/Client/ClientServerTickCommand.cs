using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets;

namespace ClashLand.Commands.Client
{
    // Packet 553
    internal class ClientServerTickCommand : Command
    {
        public int Tick;
        internal int Unknown1;

        public ClientServerTickCommand(Reader reader, Device client, int id) : base(reader, client, id)
        {
        }

        internal override void Decode()
        {
            this.Unknown1 = this.Reader.ReadInt32();
            base.Decode();
            //this.Tick = this.Reader.ReadInt32();
        }
    }
}