using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Extensions.Binary;
using ClashLand.Packets;
using ClashLand.Extensions.List;

namespace ClashLand.Logic.DataSlots
{
    internal class BookmarkSlot
    {
        public long Value;

        public BookmarkSlot(long value)
        {
            Value = value;
        }

        public void Decode(Reader br)
        {
            Value = br.Read();
        }

        public byte[] Encode()
        {
            var data = new List<byte>();
            return data.ToArray();
        }

        public void Load(JObject jsonObject)
        {
            Value = jsonObject["id"].ToObject<int>();
        }

        public JObject Save(JObject jsonObject)
        {
            jsonObject.Add("id", Value);
            return jsonObject;
        }
    }
}
