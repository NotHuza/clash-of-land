using System;
using System.Collections.Generic;
using ClashLand.Commands.Client;
using ClashLand.Packets.Commands.Client;
using ClashLand.Packets.Commands.Client.Battle;
using ClashLand.Packets.Commands.Client.Clan;
using ClashLand.Packets.Commands.Server;

namespace ClashLand.Packets
{
    internal class CommandFactory
    {
        public static Dictionary<int, Type> Commands;

        public CommandFactory()
        {
            Commands = new Dictionary<int, Type>
            {
                {1, typeof(Joined_Alliance)},
                {2, typeof(Leaved_Alliance)},
                {3, typeof(Name_Change_Callback)},
                {4, typeof(Donate_Troop_Callback)},
                {5, typeof(Receive_Troop_Callback)},
                {6, typeof(Changed_Alliance_Setting)},
                {7, typeof(Gems_Added)},
                {8, typeof(Role_Update)},
                {21,typeof(New_Promotion)},

                {500, typeof(Buy_Building)},
                {501, typeof(Move_Building)},
                {502, typeof(Upgrade_Building)},
                {503, typeof(SellGameObjects)},
                {504, typeof(SpeedUp_Construction)},
                {505, typeof(CancelConstruction)},
                {506, typeof(Collect_Resources)},
                {507, typeof(Remove_Obstacle)},
                {508, typeof(Train_Unit)},
                {509, typeof(CancelUnitProduction)},
                {510, typeof(Buy_Trap)},
                {511, typeof(Request_Alliance_Troops)},
                {512, typeof(Buy_Deco)},
                {513, typeof(SpeedUpTraining)},
                {514, typeof(SpeedUpClearing)},
                {515, typeof(CancelUpgradeUnit)},
                {516, typeof(Upgrade_Unit)},
                {517, typeof(SpeedUp_Upgrade_Unit)},
                {518, typeof(Buy_Resource)},
                {519, typeof(Mission_Progress)},
                {520, typeof(Unlock_Building)},
                {521, typeof(Free_Worker)},
                {522, typeof(BuyShield)},
                {523, typeof(ClaimAchievementRewardCommand)},
                {524, typeof(Change_Weapon_Mode)},
                {525, typeof(LoadTurret)},
                {526, typeof(Boost_Building)},
                {527, typeof(Upgrade_Hero)},
                {528, typeof(SpeedUp_Hero_Upgrade)},
                {529, typeof(ToggleHeroSleep)},
                {530, typeof(SpeedUpHeroHealth)},
                {531, typeof(CancelHeroUpgrade)},
                {532, typeof(New_Shop_Items_Seen)},
                {533, typeof(Move_Multiple_Buildings)},
                {534, typeof(Remove_Protection)},
                {535, typeof(ChangeLeague)},
                {536, typeof(Buy_Building)},
                {537, typeof(Send_Mail)},
                {538, typeof(My_League)},
                {539, typeof(News_Seen)},
                {540, typeof(Troop_Request_Message)},
                {541, typeof(SpeedUpTroopRequest)},
                {542, typeof(ShareReplay)},
                {543, typeof(ElderKick)},
                {544, typeof(EditModeShown)},
                {545, typeof(Replay)},
                {546, typeof(EditVillageLayout)},
                {549, typeof(Upgrade_Multiple_Buildings)},
                //{550, typeof(RemoveUnits)}, //old command from older version
                {552, typeof(SaveVillageLayout)},
                {553, typeof(ClientServerTickCommand)},
                {554, typeof(Change_Weapon_Heading)},
                {567, typeof(SetActiveVillageLayout)},
                {568, typeof(CopyVillageLayout)},
                {571, typeof(FilterChat)},
                {573, typeof(ShieldCostSeen)},
                {574, typeof(Request_Amical_Challenge)},
                {577, typeof(Swap_Buildings)},
                {579, typeof(Friend_List_Opened)},
                {584, typeof(Boost_Building)},
                {590, typeof(Buy_Multiple_Wall)},
                {591, typeof(Change_Village_Mode)},
                {592, typeof(Train_Unit_V2)},
                {593, typeof(SpeedupTrainV2)},
                {596, typeof(CancelUnitProductionV2)},
                {597, typeof(EventSeen)},
                //{598, typeof(Move_Multiple_Buildings_Edit_Mode)},
                //{599, typeof(Swap_Building_Edit_Mode)},
                {600, typeof(Gear_Up)},
                {601, typeof(Search_Opponent_2)},
                {603, typeof(Account_Bound)},
                //{604, typeof(Builder_Menu_Seen)},
                //{605, typeof(Challenge_Friend_Cancel)},
                {700, typeof(Place_Attacker)},
                {701, typeof(Place_Alliance_Attacker)},
                {702, typeof(EndAttackPreparation)},
                {703, typeof(Surrender_Attack)},
                {704, typeof(Place_Spell)},
                {705, typeof(Place_Hero)},
                {706, typeof(Hero_Rage)},
                {800, typeof(Search_Opponent)},
                {801, typeof(CommandFailed)}
            };
        }
    }
}
