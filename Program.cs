using System.ComponentModel;
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


// ###############################################
// Serialization of records
// var jsonSerializerOptions = new JsonSerializerOptions()
// {
//     WriteIndented = true
// };

// var myObject = new MyObject(new MyKey(Guid.NewGuid()), "My Name", new AmountPayed("EUR", 1000));

// var json = JsonSerializer.Serialize(myObject, jsonSerializerOptions);
// ###############################################

// ###############################################
// Block signature

var jsonSerializerOptions = new JsonSerializerOptions()
{
    WriteIndented = true
};

var unsignedGenesisBlock = UnsignedBlock.CreateGenesisBlock();

var rawJson = "{\n  \"Token\": \"HUSH\",\n  \"Reward\": \"5\",\n  \"TransactionId\": \"9e972141-178f-476d-ace6-ceeb169a342f\",\n  \"TimeStamp\": \"2025-01-27T08:10:07.1431725Z\",\n  \"PayloadKind\": \"8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79\",\n  \"IssuerPublicKey\": \"Paulo Public Address\"\n}";
var xxx = JsonSerializer.Deserialize<UnsignedRewardTransactionType>(rawJson);

var unsignedHushRewardTrasaction = UnsignedRewardTransaction.CreateHushRewardTrasaction(
    "Paulo Public Address", 
    "HUSH", 
    "5");          // TODO: The  reward should be obtained from the settings

var json = unsignedHushRewardTrasaction.ToJson(jsonSerializerOptions);

var signedBlock = unsignedGenesisBlock.FinalizeAndSign("Paulo Aboim Pinto", "Signature");

// "{\n  \"Token\": \"HUSH\",\n  \"Reward\": \"5\",\n  \"TransactionId\": \"9e972141-178f-476d-ace6-ceeb169a342f\",\n  \"TimeStamp\": \"2025-01-27T08:10:07.1431725Z\",\n  \"PayloadKind\": \"8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79\",\n  \"IssuerPublicKey\": \"Paulo Public Address\"\n}"
// ###############################################


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
