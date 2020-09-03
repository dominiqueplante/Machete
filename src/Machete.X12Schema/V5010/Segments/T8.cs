namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T8 :
        X12Segment
    {
        Value<int> AssignedNumber { get; }
        
        Value<string> TransitFreeformData { get; }
    }
}