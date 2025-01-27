using System.Text.Json.Serialization;
using ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

namespace ConsoleRecordsTestBed.Model.Transactions;

[JsonConverter(typeof(PayloadKindConverter))]
public record struct PayloadKind(Guid Value)
{
    public static PayloadKind WithPayloadKind(Guid guid) => new(guid);

    public override readonly string ToString() => $"payload-{this.Value.ToString()}";
}