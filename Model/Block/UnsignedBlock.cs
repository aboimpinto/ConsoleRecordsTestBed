namespace ConsoleRecordsTestBed.Model.Block;


public static class UnsignedBlock
{
    public static UnsignedBlockType CreateGenesisBlock() => CreateNew(
        new BlockIndex(1),
        new BlockId(Guid.Parse("{7359ccef-763b-4adf-8f33-45db84c5121c}")),
        new BlockId(Guid.Parse("{b4d22ab7-5c77-488f-b48b-33e288f97636}")),
        []);

    public static UnsignedBlockType CreateNew(
        BlockIndex blockIndex, 
        BlockId PreviousBlockId, 
        BlockId NextBlockId, 
        params TransactionType[] transactions) 
        => new(
            BlockId.NewBlockId(), 
            blockIndex, 
            PreviousBlockId, 
            NextBlockId, 
            transactions);

    public static UnsignedBlockType CreateNew(
        BlockId blockId, 
        BlockIndex blockIndex, 
        BlockId PreviousBlockId,
        BlockId NextBlockId, 
        params TransactionType[] transactions) 
        => new(
            blockId, 
            blockIndex,
            PreviousBlockId,
            NextBlockId, 
            transactions);

    public static string GetBlockHashCode(this UnsignedBlockType unsignedBlock) => unsignedBlock.GetHashCode().ToString();

    public static BlockType FinalizeAndSign(this UnsignedBlockType unsignedBlock, string signatory, string signature) 
        => new(
            unsignedBlock.BlockId, 
            unsignedBlock.BlockIndex, 
            unsignedBlock.PreviousBlockId,
            unsignedBlock.NextBlockId,
            unsignedBlock.GetBlockHashCode(), 
            signatory, 
            signature, 
            unsignedBlock.
            Transactions);
}