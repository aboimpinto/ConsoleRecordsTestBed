namespace ConsoleRecordsTestBed;

public record TransactionType(TransactionId Id, string Description);

public record TransactionId(Guid Value)
{
    public static TransactionId NewTransactionId() => new(Guid.NewGuid());

    public override string ToString() => this.Value.ToString();
}

public static class Transaction
{
    public static TransactionType CreateNew(string description) 
        => new(TransactionId.NewTransactionId(), description);

    public static TransactionType CreateNew(TransactionId transactionId, string description) 
        => new(transactionId, description);
}