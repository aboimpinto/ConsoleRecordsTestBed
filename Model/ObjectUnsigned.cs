using System;

namespace ConsoleRecordsTestBed.Model;

public record UnsignedObject(Guid ObjectId, string Value)
{
    public override string ToString()
    {
        return $"'{ObjectId} | {Value}'";
    }
}

public record SignedObject(Guid ObjectId, string Value, string Signatory, string Signature)
{
    public override string ToString()
    {
        return $"{ObjectId} | {Value}";
    }
}

public static class ObjectSigner 
{
    public  static SignedObject Sign(UnsignedObject unsignedObject, string Signatory)
    {
        string signature = SignUnsignedObject(unsignedObject, Signatory);

        return new SignedObject(
            unsignedObject.ObjectId,
            unsignedObject.Value,
            Signatory,
            signature);
    }

    private static string SignUnsignedObject(UnsignedObject unsignedObject, string Signatory) 
        => $"Object {unsignedObject.ToString()} signed by: {Signatory}";
}