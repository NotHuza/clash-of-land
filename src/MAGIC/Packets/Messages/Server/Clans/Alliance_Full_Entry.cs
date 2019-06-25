using ClashLand.Core;
using ClashLand.Extensions;
using ClashLand.Logic;
using ClashLand.Extensions.List;
using ClashLand.Logic.Enums;

namespace ClashLand.Packets.Messages.Server.Clans
{
    internal class Alliance_Full_Entry : Message
    {
        internal Clan Clan = null;
        internal int ClanID = 0;

        public Alliance_Full_Entry(Device Device) : base(Device)
        {
            this.Identifier = 24324;
        }

        public Alliance_Full_Entry(Device Device, Clan clan) : base(Device)
        {
            this.Identifier = 24324;
            this.Clan = clan;
        }

        internal override void Encode()
        {
            if (Clan == null)
                Clan = Resources.Clans.Get(this.ClanID == 0 ? this.Device.Player.Avatar.ClanId : this.ClanID, false);

            this.Data.AddString(this.Clan.Description);
            this.Data.AddInt((int)WarState.NONE); //War state:

            this.Data.AddInt(0); 

            this.Data.Add(0); 
            //pack.AddLong(WarID);

            this.Data.Add(0);
            this.Data.AddInt(0);
            this.Data.AddRange(Clan.ToBytes);
        }
    }
}
