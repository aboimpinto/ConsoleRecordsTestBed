using System.Text.Json;

namespace ConsoleRecordsTestBed.Model.Transactions;

public abstract record AbstractTransaction(
    TransactionId TransactionId,
    DateTime TimeStamp,
    PayloadKind PayloadKind,
    string IssuerPublicAddress
    )
{
    public abstract string ToJson(JsonSerializerOptions options);
}
