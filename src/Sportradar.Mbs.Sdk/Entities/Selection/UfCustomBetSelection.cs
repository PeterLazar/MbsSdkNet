using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

public class UfCustomBetSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "uf-custom-bet";

    [JsonPropertyName("selections")]
    public UfSelection[]? Selections { get; set; }

    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }
}