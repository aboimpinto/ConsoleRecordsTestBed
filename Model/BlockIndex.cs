namespace ConsoleRecordsTestBed;

public readonly record struct BlockIndex(long Value)
{
    public override string ToString() => $"{Value}";
}
