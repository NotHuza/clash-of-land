using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Logic.Structure.Slots.Items;
using ClashLand.Packets.Messages.Server;
using ClashLand.Packets.Messages.Server.Battle;
using ClashLand.Packets.Messages.Server.Clans;

namespace ClashLand.Packets.Messages.Client.Battle
{
    internal class Attack_Alliance_Challange : Message
    {
        internal int Stream_High_ID;
        internal int Stream_Low_ID;
        public Attack_Alliance_Challange(Device device) : base(device)
        {
            // Attack_Alliance_Challange.
        }

        internal override void Decode()
        {
            this.Stream_High_ID = this.Reader.ReadInt32();
            this.Stream_Low_ID = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            var Alliance = Resources.Clans.Get(this.Device.Player.Avatar.ClanId, false);
            Entry Stream = Alliance.Chats.Get(this.Stream_Low_ID);
            if (Stream != null)
            {
                var Player = Players.Get(Stream.Sender_ID, false);
                if (Player != null)
                {
                    this.Device.Player.Avatar.Amical_ID = this.Stream_Low_ID;

                    new Pc_Battle_Data(this.Device){Enemy = Player, BattleMode = Battle_Mode.AMICAL}.Send();

                    Stream.Amical_State = Amical_Mode.LIVE_REPLAY;

                    foreach (Member Member in Alliance.Members.Values)
                    {
                        if (Member.Connected)
                        {
                            new Alliance_Stream_Entry(Member.Player.Device, Stream).Send();
                        }
                    }
                }
                else
                {
                    new Own_Home_Data(this.Device).Send();
                }
            }

        }
    }
}
