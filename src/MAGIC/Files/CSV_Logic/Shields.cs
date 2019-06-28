using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;

namespace ClashLand.Files.CSV_Logic
{
    internal class Shields : Data
    {
        public Shields(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(Row);
        }

        public string Name { get; set; }
        public string TID { get; set; }
        public string InfoTID { get; set; }
        public int TimeH { get; set; }
        public int GuardTimeH { get; set; }
        public int Diamonds { get; set; }
        public string IconSWF { get; set; }
        public string IconExportName { get; set; }
        public int CooldownS { get; set; }
        public int LockedAboveScore { get; set; }

        public override int GetTimeH() => TimeH * 3600;
        public override int GetGuardTimeH() => GuardTimeH * 3600;
    }
}
