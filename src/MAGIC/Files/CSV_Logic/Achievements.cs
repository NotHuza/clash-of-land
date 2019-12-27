using System;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;
using ClashLand.Logic.Enums;

namespace ClashLand.Files.CSV_Logic
{
    internal class Achievements : Data
    {
        internal readonly Data ActionDataData;
        internal readonly int Type;

        public Achievements(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(_Row);

            switch (this.Action)
            {
                case "upgrade":
                {
                  this.Type = 0;
                  this.ActionDataData = CSV.Tables.Get(Gamefile.Buildings).GetData(this.ActionData);
                  break;
                }

                case "npc_stars":
                {
                  this.Type = 1;
                  break;
                }

                case "clear_obstacles":
                {
                  this.Type = 2;
                  break;
                }

                case "unit_unlock":
                {
                  this.Type = 3;
                  this.ActionDataData = CSV.Tables.Get(Gamefile.Characters).GetData(this.ActionData);
                  break;
                }

                case "loot":
                {
                  this.Type = 4;
                  this.ActionDataData = CSV.Tables.Get(Gamefile.Resources).GetData(this.ActionData);
                  break;
                }

                case "victory_points":
                {
                  this.Type = 5;
                  break;
                }

                case "destroy":
                {
                  this.Type = 6;
                  this.ActionDataData = CSV.Tables.Get(Gamefile.Buildings).GetData(this.ActionData);
                  break;
                }

                case "win_pvp_attack":
                {
                  this.Type = 7;
                  break;
                }

                case "win_pvp_defense":
                {
                  this.Type = 8;
                  break;
                }

                case "donate_units":
                {
                  this.Type = 9;
                  break;
                }

                case "league":
                {
                  this.Type = 10;
                  break;
                }

                case "war_stars":
                {
                  this.Type = 11;
                  break;
                }

                case "war_loot":
                {
                  this.Type = 12;
                  break;
                }

                case "donate_spells":
                {
                  this.Type = 13;
                  break;
                }

                case "account_bound":
                {
                  this.Type = 14;
                  break;
                }

                case "vs_battle_trophies":
                {
                  this.Type = 15;
                  break;
                }

                case "gear_up":
                {
                  this.Type = 16;
                  break;
                }

                case "repair_building":
                {
                  this.Type = 17;
                  this.ActionDataData = CSV.Tables.Get(Gamefile.Buildings).GetData(this.ActionData);
                  break;
                }

                default:
                {
                  throw new Exception("Unknown Action in achievements " + this.ActionData);
                }
            }

            if (!string.IsNullOrEmpty(this.ActionData))
            {
              this.Type = 0;
              this.ActionDataData = CSV.Tables.Get(Gamefile.Buildings).GetData(this.ActionData);
            }

            if (this.Action == "victory_points")
            {
              this.Type = 5;
            }

            if (this.Action == "clear_obstacles")
            {
              this.Type = 2;
            }

            if (this.Action == "loot")
            {
              this.Type = 4;
              this.ActionDataData = CSV.Tables.Get(Gamefile.Resources).GetData(this.ActionData);
            }
            else
            {
              if (this.Action != "destroy")
              {
                  
              }
            }
            if (this.Action == "victory_points")
            {
              this.Type = 5;
            }

            if (this.Action == "victory_points")
            {
              this.Type = 5;
            }
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int LevelCount { get; set; }
        public string TID { get; set; }
        public string InfoTID { get; set; }
        public string Action { get; set; }
        public int ActionCount { get; set; }
        public string ActionData { get; set; }
        public int ExpReward { get; set; }
        public int DiamondReward { get; set; }
        public string IconSWF { get; set; }
        public string IconExportName { get; set; }
        public string CompletedTID { get; set; }
        public bool ShowValue { get; set; }
        public string AndroidID { get; set; }
        public int UIGroup { get; set; }
    }
}
