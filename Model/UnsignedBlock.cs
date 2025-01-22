using System.Text.Json;

namespace ConsoleRecordsTestBed.Model;

public record UnsignedBlockType : AbstractBlock
{
    public UnsignedBlockType(
        BlockId BlockId, 
        BlockIndex BlockIndex, 
        TransactionType[] Transactions) : base(BlockId, BlockIndex, Transactions)
    {
    }
}

public record BlockType : UnsignedBlockType, ISignature
{
    public string Signature { get; }

    public string Signatory { get; }

    public BlockType(
        BlockId BlockId, 
        BlockIndex BlockIndex, 
        string signature,
        string signatory,
        TransactionType[] Transactions) : base(BlockId, BlockIndex, Transactions)
    {
        this.Signature = signature;
        this.Signatory = signatory;
    }
}

public interface ISignature
{
    public string Signature { get; }

    public string Signatory { get; }
}


public static class UnsignedBlock
{
    public static UnsignedBlockType CreateNew(BlockIndex blockIndex, params TransactionType[] transactions) 
        => new(BlockId.NewBlockId(), blockIndex, transactions);

    public static UnsignedBlockType CreateNew(BlockId blockId, BlockIndex blockIndex, params TransactionType[] transactions) 
        => new(blockId, blockIndex, transactions);

    public static BlockType Sign(this UnsignedBlockType unsignedBlock, string signatory, string signature) 
        => new(unsignedBlock.BlockId, unsignedBlock.BlockIndex, signatory, signature, unsignedBlock.Transactions);
}