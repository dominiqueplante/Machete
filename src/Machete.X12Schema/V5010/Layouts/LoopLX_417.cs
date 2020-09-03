namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_417 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        LayoutList<LoopL0_417> LoopL0 { get; }
        
        SegmentList<X1> ExportLicense { get; }
    }
}