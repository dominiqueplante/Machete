namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPEN_823 :
        X12Layout
    {
        Segment<PEN> PensionInformation { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<DTP> DateOrTimeOrPeriod { get; }

        LayoutList<LoopINV_823> LoopINV { get; }
    }
}