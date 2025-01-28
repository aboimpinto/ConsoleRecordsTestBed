using ConsoleRecordsTestBed.Model.Transactions;

namespace ConsoleRecordsTestBed.Model;

public interface ITransactionBaseHandlerStrategy
{
    bool CanHandle(string transactionKind);

    TransactionBase Handle(string rawJson);
}
