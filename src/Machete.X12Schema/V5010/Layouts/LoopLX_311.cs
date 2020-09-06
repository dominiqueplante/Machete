namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_311 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<Y2> ContainerDetails { get; }
        
        LayoutList<LoopED_311> LoopED { get; }
        
        LayoutList<LoopL0_311> LoopL0 { get; }
    }
}