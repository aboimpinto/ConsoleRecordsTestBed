using System.Text.Json;

namespace ConsoleRecordsTestBed;


public abstract record BaseFeed(
    string FeedId, 
    string FeedDescription,
    string PublicSigningAddress, 
    string PublicEncryptingKey, 
    string PrivateEncryptingKey)
{
    public string ToJson<T>() where T : BaseFeed
    {
        return JsonSerializer.Serialize(this as T);
    }

    public virtual bool BelongsToProfile(Profile profile) => false;
}

public record PersonalFeed : BaseFeed
{
    public Profile Owner { get; }

    private PersonalFeed(
        string FeedId, 
        string PublicSigningAddress, 
        string PublicEncryptingKey, 
        string PrivateEncryptingKey,
        Profile Owner) : 
        base(FeedId, $"{Owner.DisplayName} (You)", PublicSigningAddress, PublicEncryptingKey, PrivateEncryptingKey)
    {
        this.Owner = Owner;
    }

    public static PersonalFeed Create(
        string FeedId, 
        string PublicSigningAddress, 
        string PublicEncryptingKey, 
        string PrivateEncryptingKey,
        Profile Owner)
        {
            return new(FeedId, PublicSigningAddress, PublicEncryptingKey, PrivateEncryptingKey, Owner);
        }

    public override bool BelongsToProfile(Profile profile) => 
        this.Owner.PublicSigningAddress == profile.PublicSigningAddress;    
}

public record ChatFeed : BaseFeed
{
    public Profile Participant { get; }

    public ChatFeed(
        string FeedId, 
        string FeedDescription,
        string PublicSigningAddress, 
        string PublicEncryptingKey, 
        string PrivateEncryptingKey,
        Profile Participant) : 
        base(FeedId, FeedDescription, PublicSigningAddress, PublicEncryptingKey, PrivateEncryptingKey)
    {
        this.Participant = Participant;
    }

    public static (ChatFeed, ChatFeed) Create(
        string FeedId, 
        string PublicSigningAddress, 
        string PublicEncryptingKey, 
        string PrivateEncryptingKey,
        Profile ParticipantOne,
        Profile ParticipantTwo)
    {
        var participantOne = new ChatFeed(
            FeedId, 
            ParticipantTwo.DisplayName, 
            PublicSigningAddress, 
            PublicEncryptingKey, 
            PrivateEncryptingKey, 
            ParticipantOne);
    
        var participantTwo =  new ChatFeed(
            FeedId, 
            ParticipantOne.DisplayName, 
            PublicSigningAddress, 
            PublicEncryptingKey, 
            PrivateEncryptingKey, 
            ParticipantTwo);

        return (participantOne, participantTwo);
    }  

    public override bool BelongsToProfile(Profile profile) => 
        Participant.PublicSigningAddress == profile.PublicSigningAddress;
}

public static class ChatFeedExtensions
{
    
}