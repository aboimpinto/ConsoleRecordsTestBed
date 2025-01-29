using System.Text.Json;

namespace ConsoleRecordsTestBed.Model.Transactions;

public static class UnsignedTransaction
{
    public static UnsignedTransactionType<T> Create<T>(TransactionId TransactionId, Guid PayloadKind, T Payload) 
        where T: TransactionPayloadKind => 
        new(TransactionId, PayloadKind, Payload);

    public static UnsignedTransactionType<T> Create<T>(string json) 
        where T: TransactionPayloadKind => 
        JsonSerializer.Deserialize<UnsignedTransactionType<T>>(json);
}