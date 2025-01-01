namespace ConsoleRecordsTestBed;

public record BlockType(BlockId BlockId, TransactionType[] Transactions);

public readonly record struct BlockId(Guid Value)
{
    public static BlockId NewBlockId() => new(Guid.NewGuid());

    public static BlockId BlockWithId(Guid guid) => new(guid);

    public override string ToString() => $"block-{this.Value.ToString()}";
}

public static class Block
{
    public static BlockType CreateNew(params TransactionType[] transactions) 
        => new(BlockId.NewBlockId(), transactions);

    public static BlockType CreateNew(BlockId blockId, params TransactionType[] transactions) 
        => new(blockId, transactions);
}

public abstract record Signed(string Signatory, string Signature);

public record BlockSigned : Signed
{
    public BlockId BlockId { get; }

    public TransactionType[] Transactions { get;}

    private BlockSigned(
        BlockId BlockId, 
        TransactionType[] Transactions,
        string Signatory, 
        string Signature) : base(Signatory, Signature)
    {
        return new(BlockId, Transactions);
    }

    // public BlockId BlockId { get; }
    // public TransactionType[] Transactions { get;}

    // public string Signatory { get; }
    // public string Signature { get; }

    public static BlockSigned CreateNew(
        BlockId blockId, 
        TransactionType[] transactions)
        => new BlockSigned(blockId, transactions, "Signatory", "Signature");
}