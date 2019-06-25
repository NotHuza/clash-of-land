namespace ClashLand.Packets.Commands.Client
{
    using ClashLand.Logic;
    using ClashLand.Extensions.Binary;

    internal class ToggleHeroSleep : Command
    {
        public ToggleHeroSleep(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
            
        }

        internal override void Decode()
        {
            this.Debug();
        }

        internal override void Process()
        {
            base.Process();
        }
    }
}
