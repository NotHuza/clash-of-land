using ClashLand.Extensions.List;
using ClashLand.Logic;

namespace ClashLand.Packets.Commands.Server
{
    internal class Role_Update : Command
    {
        internal Clan Clan = null;
        internal int Role;

        public Role_Update(Device _Client) : base(_Client)
        {
            this.Identifier = 8;
        }

        internal override void Encode()
        {
            this.Data.AddLong(this.Clan.Clan_ID);
            this.Data.AddInt(this.Role);
            this.Data.AddInt(this.Role);
            this.Data.AddInt(0);
        }
    }
}