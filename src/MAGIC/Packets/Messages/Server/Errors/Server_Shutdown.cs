using ClashLand.Logic;

namespace ClashLand.Packets.Messages.Server.Errors
{
    internal class Server_Shutdown : Message
    {
        public Server_Shutdown(Device _Device) : base(_Device)
        {
            this.Identifier = 20161;
        }
    }
}