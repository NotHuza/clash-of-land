using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;

namespace ClashLand.Files.CSV_Logic
{
    internal class Globals : Data
    {
        public Globals(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(Row);
        }
        public string Name { get; set; }
        public int NumberValue { get; set; }
        public bool BooleanValue { get; set; }
        public string TextValue { get; set; }
        public int[] NumberArray { get; set; }
        public int[] AltNumberArray { get; set; }
        public string StringArray { get; set; }

    }
}
