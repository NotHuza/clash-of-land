using System;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;
using ClashLand.Logic.Enums;

namespace ClashLand.Files.CSV_Logic
{
    internal class Npcs : Data
    {
        public Npcs(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(Row);
        }

        public string Name { get; set; }
        public string MapInstanceName { get; set; }
        public string[] MapDependencies { get; set; }
        public string TID { get; set; }
        public int ExpLevel { get; set; }
        public string UnitType { get; set; }
        public int UnitCount { get; set; }
        public string LevelFile { get; set; }
        public int Gold { get; set; }
        public int Elixir { get; set; }
        public bool AlwaysUnlocked { get; set; }
        public string PlayerName { get; set; }
        public string AllianceName { get; set; }
        public int AllianceBadge { get; set; }
        public bool SinglePlayer { get; set; }

        public Characters GetUnitType() => CSV.Tables.Get(Gamefile.Characters).GetData(UnitType) as Characters;
    }
}
