using System.Collections.Generic;
using ClashLand.Logic.Structure.Slots.Items;

namespace ClashLand.Logic.Manager.AchievementManager
{
    public class AchievementsSlot : List<Achievement>
    {
        public new void Add(Achievement achievement)
        {
            if (!Contains(achievement))
                base.Add(achievement);
        }
    }
}