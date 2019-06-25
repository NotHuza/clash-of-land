using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Logic.Structure.Slots;
using ClashLand.Packets.Messages.Server.Battle;
using Resources = ClashLand.Core.Resources;

namespace ClashLand.Packets.Commands.Client.Battle
{
    internal class Search_Opponent_2 : Command
    {
        public Search_Opponent_2(Reader _Reader, Device _Client, int _ID) : base(_Reader, _Client, _ID)
        {
        }

        internal override void Process()
        {
            if (Resources.Battles_V2.Waiting.Count == 0)
            {
                Resources.Battles_V2.Enqueue(this.Device.Player);

                this.Device.State = State.SEARCH_BATTLE;
            }
            else
            {
                Level Enemy = Resources.Battles_V2.Dequeue();

                Enemy.Avatar.Battle_ID_V2 = Resources.Battles_V2.Seed;
                this.Device.Player.Avatar.Battle_ID_V2 = Resources.Battles_V2.Seed;

                Battle_V2 Battle = new Battle_V2(this.Device.Player, Enemy);
                Resources.Battles_V2.TryAdd(Resources.Battles_V2.Seed++, Battle);

                new V2_Battle_Info(this.Device, Enemy).Send();

                new Pc_Battle_Data_V2(this.Device, Enemy).Send();

                new V2_Battle_Info(Enemy.Device, this.Device.Player).Send();
                new Pc_Battle_Data_V2(Enemy.Device, this.Device.Player).Send();
            }
        }
    }
}
