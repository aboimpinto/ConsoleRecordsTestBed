using System.Text.Json;

namespace ConsoleRecordsTestBed.Model.Transactions;

public record UnsignedTransactionType<T>(
    TransactionId TransactionId, 
    T Payload)
    where T: TransactionPayloadKind

{
    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }   
}

public record TransactionPayloadKind;

public record RewardPayload(string Token, string Amount) : TransactionPayloadKind;

public static class UnsignedTransaction
{
    public static UnsignedTransactionType<T> Create<T>(TransactionId TransactionId, T Payload) 
        where T: TransactionPayloadKind => 
        new(TransactionId, Payload);

    public static UnsignedTransactionType<T> Create<T>(string json) 
        where T: TransactionPayloadKind => 
        JsonSerializer.Deserialize<UnsignedTransactionType<T>>(json);
}