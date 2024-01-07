using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Cancellation;

public class ReofferCancelDetails : CancelDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "reoffer";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}