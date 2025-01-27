using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

public class TokenRewardConverter : JsonConverter<TokenReward>
{
    public override TokenReward Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, TokenReward value, JsonSerializerOptions options)
    {
        writer.WriteString("Token", value.Token);
        writer.WriteString("Reward", value.Reward);
    }
}
