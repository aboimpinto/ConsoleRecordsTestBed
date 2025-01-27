using System.Text.Json.Serialization;
using ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

namespace ConsoleRecordsTestBed.Model.Transactions;

[JsonConverter(typeof(TransactionIdConverter))]
public record struct TransactionId(Guid Value)
{
    public static TransactionId NewTransactionId() => new(Guid.NewGuid());

    public static TransactionId WithTransactionId(Guid guid) => new(guid);

    public static TransactionId EmptyTransactionId() => new(Guid.Empty);

    public override string ToString() => $"transaction-{this.Value.ToString()}";
}
