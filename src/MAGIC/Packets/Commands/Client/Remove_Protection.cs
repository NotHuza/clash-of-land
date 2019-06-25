using ClashLand.Logic;
using ClashLand.Extensions.Binary;
using ClashLand.Core.Networking;
using ClashLand.Packets.Messages.Server;
using ClashLand.Packets.Messages.Server.Errors;

namespace ClashLand.Packets.Commands.Client
{
    
    internal class Remove_Protection : Command
    {
        public Remove_Protection(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
            
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Tick = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            if (this.Device.Player.Avatar.Shield > 0)
            {
                this.Device.Player.Avatar.Shield = 0;
            }
            else if (this.Device.Player.Avatar.Guard > 0)
            {
                this.Device.Player.Avatar.Guard = 0;
            }
            else new Out_Of_Sync(this.Device).Send();
        }
    }
}
