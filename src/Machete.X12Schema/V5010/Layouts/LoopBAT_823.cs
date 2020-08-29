namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopBAT_823 :
        X12Layout
    {
        Segment<AMT> Batch { get; }
        
        SegmentList<AVA> FundsAvailability { get; }
        
        Segment<AMT> MonetaryAmountInformation { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }

        LayoutList<LoopBPR_823> LoopBPR { get; }
    }
}