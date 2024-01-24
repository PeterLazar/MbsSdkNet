using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class CasinoGame
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}