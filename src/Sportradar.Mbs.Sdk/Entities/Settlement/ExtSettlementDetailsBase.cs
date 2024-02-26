using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Settlement;

/// <summary>
/// Represents the base class for external settlement details.
/// </summary>
[JsonConverter(typeof(ExtSettlementDetailsBaseJsonConverter))]
public abstract class ExtSettlementDetailsBase
{
}

public class ExtSettlementDetailsBaseJsonConverter : JsonConverter<ExtSettlementDetailsBase>
{
    public override ExtSettlementDetailsBase Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        ExtSettlementDetailsBase? result = type switch
        {
            "bet" => JsonSerializer.Deserialize<BetExtSettlementDetails>(root.GetRawText()),
            "ticket" => JsonSerializer.Deserialize<TicketExtSettlementDetails>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of ExtSettlementDetailsBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null ExtSettlementDetailsBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, ExtSettlementDetailsBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}