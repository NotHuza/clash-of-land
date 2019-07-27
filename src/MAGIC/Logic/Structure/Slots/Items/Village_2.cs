using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClashLand.Logic.Structure.Slots.Items
{
    internal class Village_2
    {
        [JsonProperty("TownHallMaxLevel")] internal int TownHallMaxLevel = 8;
        [JsonProperty("ScoreChangeForLosing")] internal JArray ScoreChangeForLosing = new JArray();
        [JsonProperty("StrengthRangeForScore")] internal JArray StrengthRangeForScore = new JArray();

    }
}
