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

        // if (payloadKind == "8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79")
        // {
        //     return (TransactionBase) JsonSerializer.Deserialize<UnsignedTransactionType<RewardPayload>>(element.GetRawText());
        // }

        throw new InvalidOperationException("No specific deserializer found for the transaction type.");
    }

    public override void Write(Utf8JsonWriter writer, TransactionBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
