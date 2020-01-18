using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Extensions.Binary;
using ClashLand.Core.Networking;
using ClashLand.Logic.Enums;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots;

namespace ClashLand.Packets.Messages.Server
{
    // Packet 24341
    internal class BookmarksListMessage : Message
    {
        public Player Avatar  { get; set; }

        internal string Bookmark;
        //public object Bookmark { get; private set; }

        public int i;

        public BookmarksListMessage(Device Device, Reader Reader) : base(Device, Reader)
        {
            this.Identifier = 24341;
            //this.Bookmark = BookmarkListMessage;
        }

        public BookmarksListMessage(Device Device) : base(Device)
        {
        }

        internal override void Encode()
        {
            //this.Data.AddInt(0);
            //this.Data.AddInt(0);
            //this.Data.AddString(this.Name);
        }
    }
}

/*internal override void Encode()
{
    var data = new List<byte>();
    var list = new List<byte>();
    /*var rem = new List<BookmarkSlot>();
    Parallel.ForEach((Avatar.BookmarkedClan), (p, l) =>
    {
        Clans a = ObjectManager.GetAlliance(p.Value);
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
    });//
}
}
}*/
