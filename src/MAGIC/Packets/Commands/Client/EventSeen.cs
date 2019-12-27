namespace ClashLand.Packets.Commands.Client
{
    using ClashLand.Logic;
    using ClashLand.Extensions.Binary;

    internal class EventSeen : Command
    {
        public EventSeen(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
            
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Reader.ReadInt32();

            this.Tick = this.Reader.ReadInt32();
        }
    }
}
