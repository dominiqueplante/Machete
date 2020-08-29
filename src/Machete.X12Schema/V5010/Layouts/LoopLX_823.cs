namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_823 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<TRN> Trace { get; }

        LayoutList<LoopNM1_823> LoopNM1 { get; }
    }
}