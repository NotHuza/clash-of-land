using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.Battle;

namespace ClashLand.Packets.Messages.Client.Battle
{
    internal class Search_Opponent : Message
    {
        internal long Enemy_ID;
        internal bool Max_Seed_Achieved;
        internal Level Enemy_Player;

        public Search_Opponent(Device device, object p) : base(device)
        {
            // Search_Opponent.
        }

        internal override void Process()
        {

            this.Device.Player.Avatar.Last_Attack_Enemy_ID.Clear();
            new Battle_Failed(this.Device).Send(); //No idea how to reply yet

        }
    }
}
