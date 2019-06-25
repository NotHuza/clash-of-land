using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClashLand.Logic.Structure.Slots.Items
{
    internal class Alliance_Games
    {
        [JsonProperty("last_id")] internal int Last_Id;

        [JsonProperty("last_seen")] internal int Last_Seen;

        [JsonProperty("last_end")] internal int Last_End;

        [JsonProperty("p_score")] internal int P_Score;

        [JsonProperty("p_max")] internal int P_Max;

        [JsonProperty("cooldown")] internal int Cooldown;

        [JsonProperty("n_cooldown")] internal int N_Cooldown;

        [JsonProperty("last_seen_id")] internal int Last_Seen_Id;

        [JsonProperty("thresholds")] internal int[] Thresholds;

        [JsonProperty("rewards")] internal List<Rewards> Rewards = new List<Rewards>();
        
        [JsonProperty("thresholdXP")] internal int[] ThresholdXP;

        [JsonProperty("reward_indices")] internal int[] Reward_Indices;

        [JsonProperty("rewards_claimed")] internal bool Rewards_Claimed;
    }

    internal class Rewards
    {
        [JsonProperty("id")] internal int Id;

        [JsonProperty("cnt")] internal int Cnt;

        [JsonProperty("wgt")] internal int Wgt;
    }
}
