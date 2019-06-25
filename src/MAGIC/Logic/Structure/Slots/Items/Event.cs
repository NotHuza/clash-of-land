using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClashLand.Logic.Structure.Slots.Items
{
    internal class Event
    {
        [JsonProperty("type")] internal int Type;

        [JsonProperty("id")] internal int ID;

        [JsonProperty("version")] internal int Version;

        [JsonProperty("visibleTime")] internal string VisibleTime = DateTime.UtcNow.ToString();

        [JsonProperty("startTime")] internal string StarTime = DateTime.UtcNow.ToString();

        [JsonProperty("endTime")] internal string EndTime = DateTime.UtcNow.ToString();

        [JsonProperty("clashboxEntry")] internal string ClashBoxEntry = string.Empty;

        [JsonProperty("eventEntryName")] internal string EventEntryName = string.Empty;

        [JsonProperty("inboxEntryId")] internal int InboxEntryID = 1;

        [JsonProperty("notificationTid", DefaultValueHandling = DefaultValueHandling.Ignore)] internal string NotificationTiD = string.Empty;

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Ignore)] internal string Image = string.Empty;

        [JsonProperty("sc", DefaultValueHandling = DefaultValueHandling.Ignore)] internal string SCFile = string.Empty;

        [JsonProperty("localization", DefaultValueHandling = DefaultValueHandling.Ignore)] internal string Localization = string.Empty;

        [JsonProperty("functions")] internal List<Functions> Functions = new List<Functions>();
    }
}
