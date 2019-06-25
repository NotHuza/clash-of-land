using ClashLand.Core;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Structure.Slots.Items;

namespace ClashLand.Packets.Messages.Client.Clans
{
    internal class Add_Alliance_Message : Message
    {
        internal string Message = string.Empty;

        public Add_Alliance_Message(Device device) : base(device)
        {

        }

        internal override void Decode()
        {
            this.Message = this.Reader.ReadString();
        }

        internal override void Process()
        {
            Resources.Clans.Get(this.Device.Player.Avatar.ClanId).Chats.Add(
                new Entry
                {
                    Stream_Type = Logic.Enums.Alliance_Stream.CHAT,
                    Sender_ID = this.Device.Player.Avatar.UserId,
                    Sender_Name = this.Device.Player.Avatar.Name,
                    Sender_Level = this.Device.Player.Avatar.Level,
                    Sender_League = this.Device.Player.Avatar.League,
                    Sender_Role = Resources.Clans.Get(this.Device.Player.Avatar.ClanId).Members[this.Device.Player.Avatar.UserId].Role,
                    Message = this.Message
                });
        }
    }
}
