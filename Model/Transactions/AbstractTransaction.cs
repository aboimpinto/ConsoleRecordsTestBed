using System.Text.Json;

namespace ConsoleRecordsTestBed.Model.Transactions;

public abstract record AbstractTransaction(
    TransactionId TransactionId,
    DateTime TimeStamp,
    PayloadKind PayloadKind,
    string IssuerPublicKey
    )
{
    public abstract string ToJson(JsonSerializerOptions options);
}
