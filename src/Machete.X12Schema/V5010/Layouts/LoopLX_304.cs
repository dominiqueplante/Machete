namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_304 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        Segment<Y2> ContainerDetails { get; }
        
        LayoutList<LoopN7_304> LoopN7 { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<K1> Remarks { get; }
        
        LayoutList<LoopPO4_304> LoopPO4 { get; }
        
        LayoutList<LoopL0_304> LoopL0 { get; }
    }
}