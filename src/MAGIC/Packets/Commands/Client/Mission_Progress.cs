using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Files;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Packets.Messages.Server.Errors;

namespace ClashLand.Packets.Commands.Client
{
    internal class Mission_Progress : Command
    {
        internal int Mission_ID;

        public Mission_Progress(Reader _Reader, Device _Client, int _ID) : base(_Reader, _Client, _ID)
        {

        }

        internal override void Decode()
        {
            this.Mission_ID = this.Reader.ReadInt32();
            this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            if (this.Device.Player.Avatar.Mission_Finish(Mission_ID))
            {
                Missions Mission = CSV.Tables.Get(Gamefile.Missions).GetDataWithID(Mission_ID) as Missions;
            }
        }
    }
}
