namespace ConsoleRecordsTestBed.Model.Transactions;

public record FinalizedTransactionType<T> : SignedTransactionType<T>
    where T: TransactionPayloadKind 
{
    public string Hash { get; init; }

    public FinalizedTransactionType(
        TransactionId TransactionId, 
        Guid PayloadKind, 
        T Payload,
        string signature,
        string signatory,
        string hash) 
        : base(TransactionId, PayloadKind, Payload, signatory, signature)
    {
        this.Hash = hash;
    }
}