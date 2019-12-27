using ClashLand.Extensions.Binary;
using ClashLand.Logic;

namespace ClashLand.Packets.Commands.Client
{
    // Packet 603
    internal class Account_Bound : Command
    {
        public Account_Bound(Reader reader, Device client, int id) : base(reader, client, id)
        {
        }
    }
}