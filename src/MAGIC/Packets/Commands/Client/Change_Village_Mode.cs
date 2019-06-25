using System;
using ClashLand.Core;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Enums;

namespace ClashLand.Packets.Commands.Client
{
    internal class Change_Village_Mode : Command
    {
        internal int Tick;
        public Change_Village_Mode(Reader reader, Device client, int id) : base(reader, client, id)
        {
            
        }

        internal override void Decode()
        {
            this.Device.Player.Avatar.Variables.Set(Variable.VillageToGoTo, this.Reader.ReadInt32());
            this.Tick = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
#if DEBUG       
            Loggers.Log($"Village Manager : Changing mode to {(Village_Mode)this.Device.Player.Avatar.Variables.Get(Variable.VillageToGoTo)}", true);
#endif
        }
    }
}
