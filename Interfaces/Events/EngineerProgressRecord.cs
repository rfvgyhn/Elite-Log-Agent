﻿using Newtonsoft.Json;

namespace DW.ELA.Interfaces.Events;

public class EngineerProgressRecord
{
    public enum ProgressState
    {
        Invited, Known, Unlocked
    }

    [JsonProperty("Engineer")]
    public required string EngineerName { get; set; }

    [JsonProperty("EngineerID")]
    public long? EngineerId { get; set; }

    [JsonProperty("Progress")]
    public ProgressState Progress { get; set; }

    [JsonProperty("RankProgress", NullValueHandling = NullValueHandling.Ignore)]
    public long? RankProgress { get; set; }

    [JsonProperty("Rank", NullValueHandling = NullValueHandling.Ignore)]
    public long? Rank { get; set; }
}