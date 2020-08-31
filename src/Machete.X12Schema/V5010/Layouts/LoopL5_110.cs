namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL5_110 :
        X12Layout
    {
        Segment<L5> DescriptionMarksAndNumbers { get; }
        
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<L4> Measurement { get; }
        
        SegmentList<L10> WeightInformation { get; }
        
        Segment<SL1> TariffDetails { get; }
        
        LayoutList<LoopL1_110> LoopL1 { get; }
    }
}