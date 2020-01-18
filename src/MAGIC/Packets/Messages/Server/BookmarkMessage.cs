using System.Collections.Generic;
using System.Threading.Tasks;
using ClashLand.Extensions.List;
using ClashLand.Core;
using ClashLand.Files;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots;

namespace ClashLand.Packets.Messages.Server
{
    internal class BookmarkMessage : Message
    {
        internal List<long> ToRemove;

        public BookmarkMessage(Device device, string bookmark = null) : base(device)
        {
            Identifier = 24340;
            //this.Bookmark = Bookmark;
            Bookmark = bookmark;
        }

        internal override void Encode()
        {
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddString(this.Bookmark);
        }
    }
}

/*public override void Encode()
{
    var i = 0;
    var Avatar = Device.Player.Avatar;

    ToRemove = new List<long>();
    var list = new List<byte>();

    foreach (var id in Avatar.Bookmarks)
    {
        var a = ObjectManager.GetAlliance(id);
        if (a != null)
        {
            list.AddLong(id);
            i++;
        }
        else
        {
            ToRemove.Add(id);
        }
    }
    Data.AddInt(i);
    Data.AddRange(list.ToArray());
}

public override void Process()
        {
            foreach (var id in ToRemove)
                Device.Player.Avatar.Bookmarks.RemoveAll(t => t == id);
        }
    }
}*/
