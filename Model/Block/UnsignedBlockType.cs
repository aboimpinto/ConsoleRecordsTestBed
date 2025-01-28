using System.Text.Json;
using ConsoleRecordsTestBed.Model.Transactions;

namespace ConsoleRecordsTestBed.Model.Block;

public record UnsignedBlockType : AbstractBlock
{
    public UnsignedBlockType(
        BlockId BlockId, 
        BlockIndex BlockIndex, 
        BlockId PreviousBlockId,
        BlockId NextBlockId,
        TransactionBase[] Transactions) : base(
            BlockId, 
            BlockIndex, 
            PreviousBlockId, 
            NextBlockId, 
            Transactions)
    {
    }

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
