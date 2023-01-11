﻿using DW.ELA.Interfaces;
using Newtonsoft.Json;

namespace DW.ELA.Interfaces.Events;

public class QuitACrew : JournalEvent
{
    [JsonProperty("Captain")]
    public required string Captain { get; set; }
}