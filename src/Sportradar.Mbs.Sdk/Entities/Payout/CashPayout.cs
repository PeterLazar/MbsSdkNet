using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Payout;

/// <summary>
/// Represents a cash payout.
/// </summary>
public class CashPayout : PayoutBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cash";

    /// <summary>
    /// Gets or sets the trace ID.
    /// </summary>
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
}