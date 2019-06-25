/*using System.IO;
using ClashLand.Core.Networking;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Logic;
using ClashLand.Packets;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packet.Messages.Client
{
    // Packet 14341
    internal class AskForBookmarkMessage : Message
    {
        public AskForBookmarkMessage(PacketProcessing.Client client, PacketReader br) : base(client, br)
        {
        }

        public void Decode()
        {
        }

        public void Process(Level level)
        {
            new BookmarkListMessage(Client).Send();
        }
    }
}*/