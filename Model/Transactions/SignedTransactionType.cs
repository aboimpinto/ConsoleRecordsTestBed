namespace ConsoleRecordsTestBed.Model.Transactions;

public record SignedTransactionType<T> : UnsignedTransactionType<T>
    where T: TransactionPayloadKind 
{
    public string Sinatory { get; init; }

    public string Sinature { get; init; }

    public SignedTransactionType(
        TransactionId TransactionId, 
        Guid PayloadKind, 
        T Payload,
        string signature,
        string signatory) 
        : base(TransactionId, PayloadKind, Payload)
    {
        this.TransactionId = TransactionId;
        this.PayloadKind = PayloadKind;
        this.Payload = Payload;

        this.Sinatory = signatory;
        this.Sinature = signature;
    }
}
