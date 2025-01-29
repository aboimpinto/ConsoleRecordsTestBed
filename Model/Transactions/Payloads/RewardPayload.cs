namespace ConsoleRecordsTestBed.Model.Transactions.Payloads;

public record RewardPayload(string Token, string Amount) : TransactionPayloadKind;
