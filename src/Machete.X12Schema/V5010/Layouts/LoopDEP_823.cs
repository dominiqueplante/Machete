namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopDEP_823 :
        X12Layout
    {
        Segment<DEP> Deposit { get; }

        Segment<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }

        LayoutList<LoopBAT_823> LoopBAT { get; }
    }
}