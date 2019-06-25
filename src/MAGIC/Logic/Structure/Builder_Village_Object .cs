using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Logic;

namespace ClashLand.Logic.Structure
{
    internal class Builder_Village_Object : ConstructionItem
    {
        public Builder_Village_Object(Data data, Level level) : base(data, level)
        {
        }

        internal override int ClassId => 15;

        public Village_Objects GetVillageObjectsData => (Village_Objects)GetData();
    }
}
