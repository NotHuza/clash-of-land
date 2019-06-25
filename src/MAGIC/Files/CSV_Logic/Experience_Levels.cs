using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;

namespace ClashLand.Files.CSV_Logic
{
    internal class Experience_Levels : Data
    {
        public Experience_Levels(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(_Row);
        }
        public string Name { get; set; }
        public int ExpPoints { get; set; }
    }
}
