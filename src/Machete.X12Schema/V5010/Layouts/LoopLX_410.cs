namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_410 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        LayoutList<LoopL0_410> LoopL0 { get; }
    }
}