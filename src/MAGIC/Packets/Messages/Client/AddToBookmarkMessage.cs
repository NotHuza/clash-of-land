/*using System.IO;
using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Files;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots;
using ClashLand.Packets.Messages.Server;

namespace ClashLand.Packets.Messages.Client
{
    // Packet 14343
    internal class AddToBookmarkMessage : Message
    {
        public AddToBookmarkMessage(Packets.Client client, Reader br) : base(client, br)
        {
        }

        private long id;

        public override void Decode()
        {
            using (Reader br = new PacketReader(new MemoryStream(GetData())))
            {
                id = br.ReadInt64WithEndian();
            }
        }

        public override void Process(Level level)
        {
            BookmarkSlot ds = new BookmarkSlot(id);
            level.GetPlayerAvatar().BookmarkedClan.Add(ds);
            new BookmarkAddAllianceMessage(level.GetClient()).Send();
            var user = DatabaseManager.Single().Save(level);
            user.Wait();
        }
    }
}*/