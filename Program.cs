using ConsoleRecordsTestBed;
using ConsoleRecordsTestBed.Model.Block;

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
// Block signature

var unsignedGenesisBlock = UnsignedBlock.CreateGenesisBlock();

var signedBlock = unsignedGenesisBlock.FinalizeAndSign("Paulo Aboim Pinto", "Signature");
// ###############################################


Console.ReadLine();

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
