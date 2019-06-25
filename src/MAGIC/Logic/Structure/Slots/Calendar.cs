using System.Collections.Generic;
using ClashLand.Logic.Structure.Slots.Items;
using Newtonsoft.Json;

namespace ClashLand.Logic.Structure.Slots
{
    internal class Calendar
    {
        [JsonProperty("events")]  internal List<Event> Events = new List<Event>();
    }
}
