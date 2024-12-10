namespace ConsoleRecordsTestBed;

public record Profile(
    string DisplayName,
    string PublicSigningAddress,
    string PublicEncryptingKey,
    bool IsPublic
 );
