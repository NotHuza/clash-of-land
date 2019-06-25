using ClashLand.Core.Networking;
using ClashLand.Extensions.List;
using ClashLand.Logic;

namespace ClashLand.Packets.Messages.Server
{
    internal class Server_Commands : Message
    {
        internal Command Command = null;

        public Server_Commands(Device Device, Command Command) : base(Device)
        {
            this.Identifier = 24111;
            this.Command = Command.Handle();
        }

        public Server_Commands(Device Device) : base(Device)
        {
            this.Identifier = 24111;
        }

        internal override void Encode()
        {
            this.Data.AddInt(this.Command.Identifier);
            this.Data.AddRange(this.Command.Data);
        }
    }
}