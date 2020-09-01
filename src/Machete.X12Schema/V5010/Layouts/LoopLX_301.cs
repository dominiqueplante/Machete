namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_301 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        Segment<N7> EquipmentDetails { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
        
        SegmentList<K1> Remarks { get; }
        
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        Segment<L5> DescriptionMarksAndNumbers { get; }
        
        SegmentList<L4> Measurement { get; }
        
        Segment<L1> RateAndCharges { get; }
        
        LayoutList<LoopH1_301> LoopH1 { get; }
        
        LayoutList<LoopLH1_301> LoopLH1 { get; }
    }
}