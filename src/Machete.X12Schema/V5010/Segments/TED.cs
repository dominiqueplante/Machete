namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TED :
        X12Segment
    {
        Value<string> ApplicationErrorConditionCode { get; }
        
        Value<string> FreeformMessage { get; }
        
        Value<string> SegmentIdCode { get; }
        
        Value<string> SegmentPositionInTransactionSet { get; }
        
        Value<C030> PositionInSegment { get; }
        
        Value<C999> ReferenceInSegment { get; }
        
        Value<string> CopyOfBadDataElement { get; }
        
        Value<string> DataElementNewContent { get; }
    }
}