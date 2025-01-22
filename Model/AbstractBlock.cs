namespace ConsoleRecordsTestBed;

public abstract record AbstractBlock(
    BlockId BlockId, 
    BlockIndex BlockIndex,
    TransactionType[] Transactions);
