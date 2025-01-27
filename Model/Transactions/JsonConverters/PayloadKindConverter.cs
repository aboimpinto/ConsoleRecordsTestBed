using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

public class PayloadKindConverter : JsonConverter<PayloadKind>
{
    public override PayloadKind Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, PayloadKind value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value);        
    }
}
