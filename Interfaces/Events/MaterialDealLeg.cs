﻿using Newtonsoft.Json;

namespace DW.ELA.Interfaces.Events;

public class MaterialDealLeg
{
    [JsonProperty("Material")]
    public required string Material { get; set; }

    [JsonProperty("Material_Localised")]
    public string? MaterialLocalised { get; set; }

    [JsonProperty("Category")]
    public required string Category { get; set; }

    [JsonProperty("Category_Localised")]
    public string? CategoryLocalised { get; set; }

    [JsonProperty("Quantity")]
    public long Quantity { get; set; }
}