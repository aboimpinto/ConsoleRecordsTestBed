namespace ConsoleRecordsTestBed.Model.Block;

public readonly record struct BlockIndex(long Value)
{
    public override string ToString() => $"{Value}";
}
