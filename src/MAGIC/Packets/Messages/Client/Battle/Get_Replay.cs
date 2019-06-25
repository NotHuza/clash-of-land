using System;
using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Battle;

namespace ClashLand.Packets.Messages.Client.Battle
{
    internal class Get_Replay : Message
    {
        internal long Replay_ID;

        public Get_Replay(Device device) : base(device)
        {
            // Get_Replay.
        }

        internal override void Decode()
        {
            this.Replay_ID = this.Reader.ReadInt64();
            this.Reader.ReadByte();
            this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            this.Device.State = Logic.Enums.State.REPLAY;
            new Replay_Data(this.Device) { Battle_ID = this.Replay_ID }.Send();
        }
    }
}
