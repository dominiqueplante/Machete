namespace Machete.X12Schema.V5010
{
    using X12;


    public interface USI :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<string> PackagingFormCode { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
    }
}