using Newtonsoft.Json;

namespace ClashLand.Logic.Structure.Slots.Items
{
    internal class Base
    {
        [JsonProperty("t", DefaultValueHandling = DefaultValueHandling.Include)] internal int Tick;
    }
}
