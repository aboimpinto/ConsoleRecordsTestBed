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
