namespace Machete.X12Schema.V5010
{
    using X12;


    public interface B2A :
        X12Segment
    {
        Value<string> TransactionSetPurpose { get; }
        
        Value<string> ApplicationType { get; }
    }
}