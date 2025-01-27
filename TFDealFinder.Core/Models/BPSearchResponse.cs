using System.Text.Json.Serialization;

namespace TFDealFinder.Core.Models;

public class BPSearchResponse
{
    [JsonPropertyName("response")]
    public Response Response { get; set; }
}

public class Response
{
    [JsonPropertyName("success")]
    public int Success { get; set; }

    [JsonPropertyName("history")]
    public List<HistoryEntry> History { get; set; }
}

public class HistoryEntry
{
    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("value_high")]
    public double ValueHigh { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
}
