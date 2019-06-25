using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Logic.Structure.Slots.Items;
using ClashLand.Packets.Commands.Server;
using ClashLand.Packets.Messages.Server;
using ClashLand.Packets.Messages.Server.Clans;

namespace ClashLand.Packets.Messages.Client.Clans
{
    internal class Join_Alliance : Message
    { 
        internal long ClanID;

        public Join_Alliance(Device device) : base(device)
        {

        }

        internal override void Decode()
        {
            this.ClanID = this.Reader.ReadInt64();
        }

        internal override void Process()
        {
            Clan Alliance = Resources.Clans.Get(this.ClanID, false);

            if (Alliance != null)
            {
                Alliance.Members.Add(this.Device.Player.Avatar);
                this.Device.Player.Avatar.ClanId = Alliance.Clan_ID;
                this.Device.Player.Avatar.Alliance_Level = Alliance.Level;
                this.Device.Player.Avatar.Alliance_Name = Alliance.Name;
                this.Device.Player.Avatar.Alliance_Role = (int)Role.Member;
                this.Device.Player.Avatar.Badge_ID = Alliance.Badge;


                new Server_Commands(this.Device)
                {
                    Command = new Joined_Alliance(this.Device) { Clan = Alliance }.Handle()
                }.Send();

                new Alliance_Full_Entry(this.Device).Send();
                new Alliance_All_Stream_Entry(this.Device).Send();

                Alliance.Chats.Add(new Entry
                {
                    Stream_Type = Alliance_Stream.EVENT,
                    Sender_ID = this.Device.Player.Avatar.UserId,
                    Sender_Name = this.Device.Player.Avatar.Name,
                    Sender_Level = this.Device.Player.Avatar.Level,
                    Sender_League = this.Device.Player.Avatar.League,
                    Sender_Role = Role.Member,
                    Event_ID = Events.JOIN_ALLIANCE,
                    Event_Player_ID = this.Device.Player.Avatar.UserId,
                    Event_Player_Name = this.Device.Player.Avatar.Name
                });
            }
        }
    }
}
