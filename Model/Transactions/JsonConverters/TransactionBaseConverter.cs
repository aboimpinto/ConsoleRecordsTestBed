using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

public class TransactionBaseConverter : JsonConverter<TransactionBase>
{
    public override TransactionBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);

        var element = jsonDocument.RootElement;
        var payloadKind = element.GetProperty("PayloadKind").GetString();

        return TransactionBaseHandler
            .Instance
            .Strategies
            .Single(x => x.CanHandle(payloadKind))
            .Handle(element.GetRawText());

        throw new InvalidOperationException("No specific deserializer found for the transaction type.");
    }

    public override void Write(Utf8JsonWriter writer, TransactionBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
