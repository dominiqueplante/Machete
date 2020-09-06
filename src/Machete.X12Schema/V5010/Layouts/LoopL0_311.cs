namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL0_311 :
        X12Layout
    {
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        Segment<L4> Measurement { get; }
        
        SegmentList<X1> ExportLicense { get; }
        
        SegmentList<X2> ImportLicense { get; }
    }
}