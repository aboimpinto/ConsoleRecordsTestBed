using ConsoleRecordsTestBed;
using static ConsoleRecordsTestBed.AddTransactionDefaults;

var genesisTransaction = Transaction.CreateNew("GenesisTransaction");

var block = Block.CreateNew();

AddTransaction addTransaction = AddUniqueTrasansactionToBlock;
block = addTransaction(block, genesisTransaction);

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
