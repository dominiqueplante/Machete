namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLQ_811 : X12Layout
    {
        Segment<LQ> IndustryCodeIdentification { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
    }
}