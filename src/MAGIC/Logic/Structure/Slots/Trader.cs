using Newtonsoft.Json;

namespace ClashLand.Logic.Structure.Slots.Items
{
    internal class Trader
    {
        [JsonProperty("day")] internal int Day;

        [JsonProperty("cycle")] internal int Cycle;

        [JsonProperty("event")] internal int Event;
        
        [JsonProperty("seen")] internal bool Seen;
    }
}
