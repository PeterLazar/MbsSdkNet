using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Common;

namespace Com.Sportradar.Mbs.Sdk.Entities.Response;

public class CashoutAckResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cashout-ack-reply";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("cashoutId")]
    public string? CashoutId { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    [JsonPropertyName("status")]
    public AcceptanceStatus? Status { get; set; }
}