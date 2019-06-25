using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic.Components;

namespace ClashLand.Logic.Structure
{
    internal class Trap : ConstructionItem
    {
        public Trap(Data data, Level l) : base(data, l)
        {
            AddComponent(new Trigger_Component());
            if (GetTrapData.HasAltMode || GetTrapData.DirectionCount > 0)
            {
                AddComponent(new Combat_Component(this));
            }
        }

        internal override int ClassId => 4;

        public Traps GetTrapData => (Traps)GetData();
    }
}