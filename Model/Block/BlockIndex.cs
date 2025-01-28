using System.Text.Json.Serialization;
using ConsoleRecordsTestBed.Model.Block.JsonConverters;

namespace ConsoleRecordsTestBed.Model.Block;

[JsonConverter(typeof(BlockIndexConverter))]
public readonly record struct BlockIndex(long Value)
{
    public override string ToString() => $"{Value}";
}
