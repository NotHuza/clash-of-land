using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic.Components;

namespace ClashLand.Logic.Structure
{
    internal class Builder_Trap : ConstructionItem
    {
        public Builder_Trap(Data data, Level l) : base(data, l)
        {
            AddComponent(new Trigger_Component());
            if (GetTrapData.HasAltMode || GetTrapData.DirectionCount > 0)
            {
                AddComponent(new Combat_Component(this));
            }
        }

        internal override int ClassId => 11;

        public Traps GetTrapData => (Traps)GetData();
    }
}