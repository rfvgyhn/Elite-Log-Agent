﻿using DW.ELA.Interfaces;
using Newtonsoft.Json;

namespace DW.ELA.Interfaces.Events;

public class JoinACrew : JournalEvent
{
    [JsonProperty("Captain")]
    public required string Captain { get; set; }
}