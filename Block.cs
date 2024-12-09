namespace ConsoleRecordsTestBed;

public record BlockType(BlockId BlockId, TransactionType[] Transactions);

public readonly record struct BlockId(Guid Value)
{
    public static BlockId NewBlockId() => new(Guid.NewGuid());

    public static BlockId BlockWithId(Guid guid) => new(guid);

    public override string ToString() => this.Value.ToString();
}

public static class Block
{
    public static BlockType Create(params TransactionType[] transactions) 
        => new(BlockId.NewBlockId(), transactions);

    public static BlockType Create(BlockId blockId, params TransactionType[] transactions) 
        => new(blockId, transactions);
}

