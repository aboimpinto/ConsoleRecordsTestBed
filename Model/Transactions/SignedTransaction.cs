namespace ConsoleRecordsTestBed.Model.Transactions;

public static class SignedTransaction
{
    public static SignedTransactionType<T> SignIt<T>(this UnsignedTransactionType<T> unsignedTransactionType)
        where T: TransactionPayloadKind 
    {
        return new SignedTransactionType<T>(
            unsignedTransactionType.TransactionId, 
            unsignedTransactionType.PayloadKind,
            unsignedTransactionType.Payload,
            "Paulo Aboim Pinto", 
            "Signature");
    }
}
