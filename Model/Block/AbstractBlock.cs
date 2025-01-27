using ConsoleRecordsTestBed.Model.Transactions;

namespace ConsoleRecordsTestBed.Model.Block;

public abstract record AbstractBlock(
    BlockId BlockId, 
    BlockIndex BlockIndex,
    BlockId PreviousBlockId,
    BlockId NextBlockId,
    AbstractTransaction[] Transactions);
