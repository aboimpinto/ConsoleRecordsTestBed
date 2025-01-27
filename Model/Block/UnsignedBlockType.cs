using ConsoleRecordsTestBed.Model.Transactions;

namespace ConsoleRecordsTestBed.Model.Block;

public record UnsignedBlockType : AbstractBlock
{
    public UnsignedBlockType(
        BlockId BlockId, 
        BlockIndex BlockIndex, 
        BlockId PreviousBlockId,
        BlockId NextBlockId,
        AbstractTransaction[] Transactions) : base(
            BlockId, 
            BlockIndex, 
            PreviousBlockId, 
            NextBlockId, 
            Transactions)
    {
    }
}
