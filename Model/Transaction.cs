// namespace ConsoleRecordsTestBed;

// public readonly record struct TransactionId(Guid Value)
// {
//     public static TransactionId Empty => new(Guid.Empty);
//     public static TransactionId NewTransactionId() => new(Guid.NewGuid());

//     public override string ToString() => $"transaction-{this.Value.ToString()}";
// }


// public record TransactionType(TransactionId Id, string Description);

// public static class Transaction
// {
//     public static TransactionType CreateNew(string description) 
//         => new(TransactionId.NewTransactionId(), description);

//     public static TransactionType CreateNew(TransactionId transactionId, string description) 
//         => new(transactionId, description);
// }


// public class TransactionType_ObjectOriented(TransactionId transactionId, string description)
// {
//     public TransactionId TransactionId { get; private set; } = transactionId;

//     public string Description { get; private set; } = description;
// }


// public static class Transaction_ObjertOriented
// {
//     public static TransactionType_ObjectOriented CreateNew(string description) 
//         => new(TransactionId.NewTransactionId(), description);

//     public static TransactionType_ObjectOriented CreateNew(TransactionId transactionId, string description) 
//         => new(transactionId, description);
// }