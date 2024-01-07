using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Selection;

public class WaysSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ways";

    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }
}