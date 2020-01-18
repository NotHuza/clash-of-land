/*using ClashLand.Logic.Structure.Slots;

namespace ClashLand.Logic
{
    internal class ModSlot : Slots
    {
        internal bool AIAttack;
        internal Level AILevel;

        internal bool SelfAttack
        {
            get => this.GetCountByGlobalId(0) == 1;
            set => this.Set(0, value ? 1 : 0);
        }

        internal void Initialize()
        {
            this.Set(0, 0);
        }
    }
}*/