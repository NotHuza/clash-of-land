using System;
using ClashLand.Extensions.Binary;
using ClashLand.Files;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic;
using ClashLand.Logic.Enums;

namespace ClashLand.Packets.Commands.Client
{
    internal class Buy_Shield : Command
    {
        public Buy_Shield(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {

        }

        /*internal override void Decode()
        {
            this.ShieldId = this.Reader.ReadInt32();
            this.Tick = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            var ca = this.Device.Player.Avatar;
            var sd = (Shields)CSV.Tables.Get(Gamefile.Shields).GetDataWithID(ShieldId);
        }

        public int ShieldId;
        public int Tick;*/
        internal override void Decode()
        {
            //this.Debug();
            this.ShieldId = this.Reader.ReadInt32();
            this.Tick = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            base.Process();
        }
        public int ShieldId;
        public int Tick;
    }
}
