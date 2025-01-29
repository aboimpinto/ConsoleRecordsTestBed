namespace ConsoleRecordsTestBed.Model.Transactions;

public static class FinalizedTransaction
{
    public static FinalizedTransactionType<T> HashIt<T>(this SignedTransactionType<T> signedTransactionType)
        where T: TransactionPayloadKind 
    {
        return new FinalizedTransactionType<T>(
            signedTransactionType.TransactionId, 
            signedTransactionType.PayloadKind,
            signedTransactionType.Payload,
            signedTransactionType.Sinatory,
            signedTransactionType.Sinature,
            signedTransactionType.GetHashCode().ToString());
    }
}
