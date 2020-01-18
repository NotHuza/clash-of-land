using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Extensions.Binary;


namespace ClashLand.Packets.Commands.Client
{
    

    internal class Seen_Builder_Menu : Command
    {
        internal int State;

        public Seen_Builder_Menu(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        //public int Tick { get; private set; }

        internal override void Decode()
        {
            this.State = this.Reader.ReadInt32();
            base.Decode();
        }

        internal override void Process()
        {
            //if (this.State == 0)
            {
                base.Process();
                //object p = this.Device.GameMode..Player.Variables.Set(Variable.SeenBuilderMenu, 1);
            }
        }
    }
}