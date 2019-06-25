using System;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Packets.Messages.Server.Battle;

namespace ClashLand.Packets.Messages.Client.Battle
{
    internal class Attack_War : Message
    {
        internal int Npc_ID;

        public Attack_War(Device device) : base(device)
        {
            // Attack_War.
        }

        internal override void Decode()
        {
            Console.WriteLine(BitConverter.ToString(this.Reader.ReadFully()));
        }

        internal override void Process()
        {
            new Pc_Battle_Data(this.Device) { Enemy = this.Device.Player, BattleMode = Battle_Mode.NEXT_BUTTON_DISABLE}.Send();
        }
    }
}
