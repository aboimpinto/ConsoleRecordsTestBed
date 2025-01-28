
using ConsoleRecordsTestBed.Model.Block;
using ConsoleRecordsTestBed.Model.Transactions;

namespace ConsoleRecordsTestBed.Model;

public delegate BlockType AddTransaction(BlockType block, AbstractTransaction transaction);

public static class AddTransactionDefaults
{
    // public static AddTransaction AddUniqueTrasansactionToBlock => (block, transaction) => 
    //     block.Transactions.Contains(transaction) 
    //         ? block
    //         : block with { Transactions = [..block.Transactions, transaction] };

}