using ConsoleRecordsTestBed.Model.Transactions.Converters;

namespace ConsoleRecordsTestBed.Model;

public class TransactionBaseHandler
{
    private static TransactionBaseHandler _instance;

    public static TransactionBaseHandler Instance 
    { 
        get 
        {
            _instance ??= new TransactionBaseHandler();
            return _instance;
        } 
    }

    public IEnumerable<ITransactionBaseHandlerStrategy> Strategies { get; set; }

    public TransactionBaseHandler()
    {
        this.Strategies =
        [
            new RewardTransactionHandlerStrategy()
        ];
        
    }
}
