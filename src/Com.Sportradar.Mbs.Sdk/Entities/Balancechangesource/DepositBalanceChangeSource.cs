using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Balancechangesource;

public class DepositBalanceChangeSource : BalanceChangeSourceBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "deposit";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}