namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL5_104 :
        X12Layout
    {
        Segment<L5> DescriptionMarksAndNumbers { get; }
        
        SegmentList<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<L1> RateAndCharges { get; }
        
        SegmentList<L4> Measurement { get; }
    }
}