﻿using Newtonsoft.Json;

namespace DW.ELA.Interfaces.Events;

public partial class Material
{
    [JsonProperty("Name")]
    public required string Name { get; set; }

    [JsonProperty("Name_Localised")]
    public string? NameLocalised { get; set; }

    [JsonProperty("Count")]
    public long Count { get; set; }
}