using System.Text.Json.Serialization;
using ConsoleRecordsTestBed.Model.Block.JsonConverters;

namespace ConsoleRecordsTestBed.Model.Block;

[JsonConverter(typeof(BlockIdConverter))]
public readonly record struct BlockId(Guid Value)
{
    public static BlockId NewBlockId() => new(Guid.NewGuid());

    public static BlockId WithBlockId(Guid guid) => new(guid);

    public static BlockId EmptyBlockId() => new(Guid.Empty);

    public override string ToString() => $"block-{this.Value.ToString()}";
}
