namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_300 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        Segment<N7> EquipmentDetails { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        Segment<L5> DescriptionMarksAndNumbers { get; }
        
        SegmentList<L4> Measurement { get; }
        
        Segment<L1> RateAndCharges { get; }
        
        LayoutList<LoopH1_300> LoopH1 { get; }
        
        LayoutList<LoopLH1_300> LoopLH1 { get; }
    }
}