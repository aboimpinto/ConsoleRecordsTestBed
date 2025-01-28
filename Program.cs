using System.ComponentModel;
using System.Runtime.Versioning;
using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleRecordsTestBed;
using ConsoleRecordsTestBed.Model.Block;
using ConsoleRecordsTestBed.Model.Transactions;

// var genesisTransaction = Transaction.CreateNew("GenesisTransaction");
// var genesisTransaction_ObjectOriented = Transaction_ObjertOriented.CreateNew("GenesisTransaction");

// var block = Block.CreateNew();

// AddTransaction addTransaction = AddUniqueTrasansactionToBlock;
// block = addTransaction(block, genesisTransaction);


// ###############################################
// Signature of simple object 

// var usigned = new UnsignedObject(Guid.NewGuid(), "objectValue");
// var signed = ObjectSigner.Sign(usigned, "Paulo");

// Console.WriteLine($"Signed Object ID: {signed.ObjectId}");
// Console.WriteLine($"Signed Object Value: {signed.Value}");
// Console.WriteLine($"Signatory: {signed.Signatory}");
// Console.WriteLine($"Signature: {signed.Signature}");

// ###############################################


var jsonSerializerOptions = new JsonSerializerOptions()
{
    WriteIndented = true
};

var unsignedGenesisBlock = UnsignedBlock.CreateGenesisBlock();

var jsonBlock = unsignedGenesisBlock.ToJson(jsonSerializerOptions);

var rewardTransaction = UnsignedTransaction.Create(
    new TransactionId(Guid.NewGuid()),
    Guid.Parse("8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79"),
    new RewardPayload("HUSH", "5")); 

var unsignedGenesisBlockWithRewardTransaction = unsignedGenesisBlock with 
    { Transactions = [..unsignedGenesisBlock.Transactions, rewardTransaction] };

var jsonBlockWithRewardTransaction = unsignedGenesisBlockWithRewardTransaction.ToJson(jsonSerializerOptions);

var block = UnsignedBlock.CreateNew(jsonBlockWithRewardTransaction);

Console.ReadLine();


[JsonConverter(typeof(MyKeyConverter))]
record MyKey(Guid Value);

[JsonConverter(typeof(AmountPayedConverter))]
record AmountPayed(string Currency, decimal Value);

record MyObject(MyKey Id, string Name, AmountPayed AmountPayed);

class MyKeyConverter : JsonConverter<MyKey>
{
    public override MyKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, MyKey value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value);
    }
}

class AmountPayedConverter : JsonConverter<AmountPayed>
{
    public override AmountPayed Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, AmountPayed value, JsonSerializerOptions options)
    {
        writer.WriteString("Currency", value.Currency);
        writer.WriteNumber("Amount", value.Value);
    }
}

// var principalProfile = new Profile("PrincipalProfile", "PrincipalProfileSigningAddress", "PrincipalProfileEncryptingAddress", true);
// var otherProfile = new Profile("OtherProfile", "OtherProfileSigningAddress", "OtherProfileEncryptingAddress", true);

// var principalPersonalFeed = PersonalFeed.Create(
//     "personalFeedId", 
//     "personalPublicSigningAddress", 
//     "personalPublicEncryptingKey", 
//     "personalPrivateEncryptingKey",
//     principalProfile);

// var (principalChatFeed, otherChatFeed) = ChatFeed.Create(
//     "chatFeedId", 
//     "chatPublicSigningAddress", 
//     "chatPublicEncryptingKey", 
//     "chatPrivateEncryptingKey",
//     principalProfile,
//     otherProfile
// );

// var feeds = new List<BaseFeed>
// {
//     principalPersonalFeed,
//     principalChatFeed,
//     otherChatFeed
// };

// Console.WriteLine($"Feeds from: {principalProfile.DisplayName}");
// feeds
//     .Where(x => x.BelongsToProfile(principalProfile))
//     .Select(feed => feed.FeedDescription)
//     .ForEach(Console.WriteLine);

// Console.WriteLine();

// Console.WriteLine($"Feeds from: {otherProfile.DisplayName}");
// feeds
//     .Where(x => x.BelongsToProfile(otherProfile))
//     .Select(feed => feed.FeedDescription)
//     .ForEach(Console.WriteLine);
