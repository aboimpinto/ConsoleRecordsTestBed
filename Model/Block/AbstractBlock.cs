namespace ConsoleRecordsTestBed.Model.Block;

public abstract record AbstractBlock(
    BlockId BlockId, 
    BlockIndex BlockIndex,
    BlockId PreviousBlockId,
    BlockId NextBlockId,
    TransactionType[] Transactions);
