using System.IO;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Extensions.List;
using ClashLand.Core;
using ClashLand.Extensions.Binary;
using ClashLand.Core.Networking;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Packets;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packets.Messages.Client
{
    // Packet 14341
    internal class AskForBookmarkMessage : Message
    {
        internal int bookmarks;
        public AskForBookmarkMessage(Device Device, Reader Reader) : base(Device, Reader)
        {
        }

        internal override void Decode()
        {
            this.bookmarks = this.Reader.ReadInt32();
        }

        public void Process(Level level)
        {
            //new BookmarksListMessage(Device).Send();
        }
    }
}