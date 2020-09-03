namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL0_410 :
        X12Layout
    {
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<L1> RateAndCharges { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<P1> Pickup { get; }
    }
}