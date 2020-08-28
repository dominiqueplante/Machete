namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLQ_824 :
        X12Layout
    {
        SegmentList<LQ> IndustryCodeIdentification { get; }
        
        SegmentList<RED> RelatedData { get; }
    }
}