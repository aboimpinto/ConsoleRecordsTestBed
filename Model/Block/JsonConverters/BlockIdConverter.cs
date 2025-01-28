using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRecordsTestBed.Model.Block.JsonConverters;

public class BlockIdConverter : JsonConverter<BlockId>
{
    public override BlockId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);

        var blockIdElement = jsonDocument.RootElement;

        return new BlockId(Guid.Parse(blockIdElement.GetString()[6..]));
    }

    public override void Write(Utf8JsonWriter writer, BlockId value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}
