using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRecordsTestBed.Model.Block.JsonConverters;

public class BlockIndexConverter : JsonConverter<BlockIndex>
{
    public override BlockIndex Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);

        var blockIndexElement = jsonDocument.RootElement;

        return new BlockIndex(Int64.Parse(blockIndexElement.GetString()));
    }

    public override void Write(Utf8JsonWriter writer, BlockIndex value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}
