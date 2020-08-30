namespace Machete.X12Schema.V5010
{
    using X12;


    public interface FGS :
        X12Segment
    {
        Value<string> AssignedIdentifier { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
    }
}