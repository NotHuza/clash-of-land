/*using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Helpers;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots;

namespace ClashLand.Packets.Messages.Server
{
    // Packet 24341
    internal class BookmarkListMessage : Message
    {
        public Avatar player { get; set; }
        public object Bookmark { get; private set; }

        public int i;

        public BookmarkListMessage(Device.Avatar, BookmarkListMessage message) : base(Avatar)
        {
            this.Identifier = 24341;
            this.Bookmark = Bookmarkmessage;
        }

        public override void Encode()
        {
            var data = new List<byte>();
            var list = new List<byte>();
            var rem = new List<BookmarkSlot>();
            Parallel.ForEach((player.BookmarkedClan), (p, l) =>
            {
                Alliance a = ObjectManager.GetAlliance(p.Value);
                if (a != null)
                {
                    list.AddRange(ObjectManager.GetAlliance(p.Value).EncodeFullEntry());
                    i++;
                }
                else
                {
                    rem.Add(p);
                    if (i > 0)
                        i--;
                }
                l.Stop();
            });
            data.AddInt32(i);
            data.AddRange(list);
            Encrypt(data.ToArray());
            Parallel.ForEach((rem), (im, l) =>
            {
                player.BookmarkedClan.RemoveAll(t => t == im);
                l.Stop();
            });
        }
    }
}*/
