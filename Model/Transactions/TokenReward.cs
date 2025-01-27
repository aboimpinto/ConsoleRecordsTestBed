using System.Text.Json.Serialization;
using ConsoleRecordsTestBed.Model.Transactions.JsonConverters;

namespace ConsoleRecordsTestBed.Model.Transactions;

[JsonConverter(typeof(TokenRewardConverter))]
public record TokenReward(string Token, string Reward) : TransactionPayload;


public record TransactionPayload;