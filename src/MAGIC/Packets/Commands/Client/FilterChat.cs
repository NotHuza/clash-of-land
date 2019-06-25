using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClashLand.Extensions.Binary;
using System.Threading.Tasks;
using ClashLand.Logic;

namespace ClashLand.Packets.Commands.Client
{
    internal class FilterChat : Command
    {
        public FilterChat(Reader reader, Device client, int id) : base(reader, client, id)
        {
        }
    }
}
