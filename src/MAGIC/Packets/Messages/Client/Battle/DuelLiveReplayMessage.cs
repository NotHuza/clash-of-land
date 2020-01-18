using System;
using ClashLand.Core.Networking;
using ClashLand.Core;
using ClashLand.Logic;
using ClashLand.Extensions.Binary;
using ClashLand.Packets.Messages.Server.Battle;



namespace ClashLand.Packets.Messages.Client.Battle
{

    internal class DuelLiveReplayMessage : Message
    {
        internal long LiveId;

        public DuelLiveReplayMessage(Device Device, Reader Reader) : base(Device, Reader)
        {
            // DuelLiveReplayMessage
        }

        internal override void Decode()
        {
            this.LiveId = this.Reader.ReadInt64();
            this.Reader.ReadByte();
            this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            this.Device.State = Logic.Enums.State.REPLAY;
            new Replay_Data(this.Device) { Battle_ID = this.LiveId }.Send();
        }
    }
}