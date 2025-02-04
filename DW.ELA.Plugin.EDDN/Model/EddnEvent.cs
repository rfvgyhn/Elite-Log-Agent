﻿using System.Collections.Generic;
using DW.ELA.Utility.Json;
using Newtonsoft.Json;

namespace DW.ELA.Plugin.EDDN.Model;

public class EddnEvent
{
    [JsonProperty("$schemaRef")]
    public virtual string SchemaRef { get; } = null!;

    [JsonProperty("header")]
    public required IDictionary<string, string> Header { get; set; }

    public override string ToString() => Serialize.ToJson(this);
}