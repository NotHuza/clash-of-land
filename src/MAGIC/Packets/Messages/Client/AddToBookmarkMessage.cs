using System.IO;
using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Files;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots;
using ClashLand.Packets.Messages.Server;
using MySql.Data.MySqlClient.Memcached;

namespace ClashLand.Packets.Messages.Client
{
    internal class AddToBookmarkMessage : Message
    {
        public AddToBookmarkMessage(Device Device, Reader Reader) : base(Device, Reader)
        {
            this.Identifier = 14343;
        }

        /*private long id;

        internal override void Decode()
        {
            using (Reader br = new Reader(new MemoryStream()
            {
                id = br.ReadInt64();
            }
        }*/

        /*internal override void Process(Level level)
        {
            BookmarkSlot ds = new BookmarkSlot(id);
            level.GetPlayerAvatar().BookmarkedClan.Add(ds);
            new BookmarkAddAllianceMessage(level.GetClient()).Send();
            var user = DatabaseManager.Single().Save(level);
            user.Wait();
        }*/
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