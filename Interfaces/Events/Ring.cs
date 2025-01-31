﻿using Newtonsoft.Json;

namespace DW.ELA.Interfaces.Events;

public class Ring
{
    [JsonProperty("Name")]
    public required string Name { get; set; }

    [JsonProperty("RingClass")]
    public required string RingClass { get; set; }

    [JsonProperty("MassMT")]
    public double MassMt { get; set; }

    [JsonProperty("InnerRad")]
    public double InnerRad { get; set; }

    [JsonProperty("OuterRad")]
    public double OuterRad { get; set; }
}