using System.Text.Json;
using ConsoleRecordsTestBed.Model.Transactions.RewardTransaction;

namespace ConsoleRecordsTestBed.Model.Transactions.Converters;

public class RewardTransactionHandlerStrategy : ITransactionBaseHandlerStrategy
{
    public bool CanHandle(string transactionKind)
    {
        if (transactionKind == "8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79")
        { 
            return true; 
        }

        return false;
    }

    public TransactionBase Handle(string rawJson)
    {
        return JsonSerializer.Deserialize<UnsignedTransactionType<RewardPayload>>(rawJson);
    }
}

