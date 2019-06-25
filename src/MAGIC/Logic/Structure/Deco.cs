using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Logic;

namespace ClashLand.Logic.Structure
{

    internal class Deco : GameObject
    {
        public Deco(Data data, Level l) : base(data, l)
        {
        }

        internal override int ClassId => 6;

        public Decos GetDecoData() => (Decos)GetData();
    }
}