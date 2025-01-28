using System.Text.Json.Serialization;
using ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

namespace ConsoleRecordsTestBed.Model.Transactions;

[JsonConverter(typeof(TransactionBaseConverter))]
public record TransactionBase(TransactionId TransactionId, Guid PayloadKind);
