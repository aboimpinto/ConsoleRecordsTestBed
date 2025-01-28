using System.Text.Json;

namespace ConsoleRecordsTestBed.Model.Transactions;

public record UnsignedTransactionType<T>
    : TransactionBase
    where T: TransactionPayloadKind 
{
    public T Payload { get; init; }

    public UnsignedTransactionType(
        TransactionId TransactionId, 
        Guid PayloadKind,
        T Payload) : base(TransactionId, PayloadKind)
    {
        this.Payload = Payload;
    }

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this as UnsignedTransactionType<T>, options);
    }   
}

public record TransactionPayloadKind;

public record RewardPayload(string Token, string Amount) : TransactionPayloadKind;

public static class UnsignedTransaction
{
    public static UnsignedTransactionType<T> Create<T>(TransactionId TransactionId, Guid PayloadKind, T Payload) 
        where T: TransactionPayloadKind => 
        new(TransactionId, PayloadKind, Payload);

    public static UnsignedTransactionType<T> Create<T>(string json) 
        where T: TransactionPayloadKind => 
        JsonSerializer.Deserialize<UnsignedTransactionType<T>>(json);
}