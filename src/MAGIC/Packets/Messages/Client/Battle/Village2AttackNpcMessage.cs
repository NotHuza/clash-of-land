namespace CR.Servers.CoC.Packets.Messages.Client.Battle
{
    using CR.Servers.CoC.Core.Network;
    using CR.Servers.CoC.Extensions.Game;
    using CR.Servers.CoC.Extensions.Helper;
    using CR.Servers.CoC.Files;
    using CR.Servers.CoC.Files.CSV_Logic.Logic;
    using CR.Servers.CoC.Logic;
    using CR.Servers.CoC.Packets.Messages.Server.Battle;
    using CR.Servers.Extensions.Binary;

    internal class Village2AttackNpcMessage : Message
    {
        internal NpcData Npc;

        public Village2AttackNpcMessage(Device Device, Reader Reader) : base(Device, Reader)
        {
        }

        internal override short Type
        {
            get
            {
                return 14135;
            }
        }

        internal override void Decode()
        {
            this.Npc = this.Reader.ReadData<NpcData>();
        }

        internal override void Process()
        {
            if (this.Npc != null)
            {
                // if (this.Data.SinglePlayer)
                {
                    //if (this.Npc.AlwaysUnlocked ||  this.Device.GameMode.Level.Player.NpcMapProgress.CanAttackNPC(this.Npc))
                    {
                        this.Device.GameMode.Level.Player.Mission_Finish(21000022);

                        new NpcDataMessage(this.Device) {NpcHome = LevelFile.Files[this.Npc.LevelFile], Npc_ID = this.Npc.GlobalId, Village2 = true}.Send();
                    }
                }
            }
        }
    }
}