namespace ConsoleRecordsTestBed.Model.Transactions.RewardTransaction;

public record RewardPayload(string Token, string Amount) : TransactionPayloadKind;
