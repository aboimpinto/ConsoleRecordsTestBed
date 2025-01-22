namespace ConsoleRecordsTestBed.Model.Block;

public record BlockType : UnsignedBlockType, ISignature
{
    public string Hash { get; }

    public string Signature { get; }

    public string Signatory { get; }

    public BlockType(
        BlockId BlockId, 
        BlockIndex BlockIndex, 
        BlockId PreviousBlockId,
        BlockId NextBlockId,
        string hash,
        string signature,
        string signatory,
        TransactionType[] Transactions) : base(
            BlockId, 
            BlockIndex, 
            PreviousBlockId, 
            NextBlockId, 
            Transactions)
    {
        Hash = hash;
        Signature = signature;
        Signatory = signatory;
    }
}
