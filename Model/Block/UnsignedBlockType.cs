namespace ConsoleRecordsTestBed.Model.Block;

public record UnsignedBlockType : AbstractBlock
{
    public UnsignedBlockType(
        BlockId BlockId, 
        BlockIndex BlockIndex, 
        BlockId PreviousBlockId,
        BlockId NextBlockId,
        TransactionType[] Transactions) : base(
            BlockId, 
            BlockIndex, 
            PreviousBlockId, 
            NextBlockId, 
            Transactions)
    {
    }
}
