namespace ConsoleRecordsTestBed.Model.Block;

public readonly record struct BlockId(Guid Value)
{
    public static BlockId NewBlockId() => new(Guid.NewGuid());

    public static BlockId WithBlockId(Guid guid) => new(guid);

    public static BlockId EmptyBlockId() => new(Guid.Empty);

    public override string ToString() => $"block-{this.Value.ToString()}";
}
