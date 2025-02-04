﻿using System;
using Newtonsoft.Json;

namespace DW.ELA.Plugin.EDDN.Model;

public partial class ShipyardMessage
{
    [JsonProperty("marketId", NullValueHandling = NullValueHandling.Ignore)]
    public long MarketId { get; set; }

    [JsonProperty("ships")]
    public required string[] Ships { get; set; }

    [JsonProperty("stationName")]
    public required string StationName { get; set; }

    [JsonProperty("systemName")]
    public required string SystemName { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }
}