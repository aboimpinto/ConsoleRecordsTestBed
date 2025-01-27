using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRecordsTestBed.Model.Transactions;

// [JsonConverter(typeof(UnsignedRewardTransactionConverter))]
public record UnsignedRewardTransactionType : AbstractTransaction
{
    // public TransactionPayload TransactionPayload { get; init; }

    public string Token { get; init; }

    public string Reward { get; init; }

    public UnsignedRewardTransactionType(
        TransactionId TransactionId,
        DateTime TimeStamp,
        PayloadKind PayloadKind,
        string IssuerPublicAddress,
        string Token, 
        string Reward) : base(
            TransactionId,
            TimeStamp,
            PayloadKind,
            IssuerPublicAddress)
    {
        // this.TransactionPayload = Payload;

        this.Token = Token;
        this.Reward = Reward;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}

public static class UnsignedRewardTransaction
{
    public static PayloadKind Identifier => new(Guid.Parse("{8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79}"));

    public static UnsignedRewardTransactionType CreateHushRewardTrasaction(
        TransactionId TransactionId,
        DateTime TimeStamp,
        PayloadKind PayloadKind,
        string IssuerPublicAddress,
        string Token, 
        string Reward)
        => new(
            TransactionId,
            TimeStamp,
            PayloadKind,
            IssuerPublicAddress,
            Token,
            Reward);

    public static UnsignedRewardTransactionType CreateHushRewardTrasaction(
        string IssuerPublicAddress,
        string Token, 
        string Reward)
        => new(
            new TransactionId(Guid.NewGuid()),
            DateTime.UtcNow,
            UnsignedRewardTransaction.Identifier,
            IssuerPublicAddress,
            Token,
            Reward);
}


public class UnsignedRewardTransactionConverter : JsonConverter<UnsignedRewardTransactionType>
{
    public override UnsignedRewardTransactionType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, UnsignedRewardTransactionType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}