using Newtonsoft.Json;

namespace CRepublic.Magic.Logic
{
    public class Achievement
    {
        [JsonProperty("data")]
        public int Data { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}