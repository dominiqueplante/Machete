namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN7_310 :
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        Segment<V4> CargoLocationReference { get; }
        
        Segment<N12> EquipmentEnvironment { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
        
        Segment<L7> TariffReference { get; }
        
        SegmentList<X1> ExportLicense { get; }
        
        SegmentList<X2> ImportLicense { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        LayoutList<LoopH1_304> LoopH1 { get; }
        
        LayoutList<LoopLH1_304> LoopLH1 { get; }
        
        Segment<L4> Measurement { get; }
        
        SegmentList<LH6> HazardousCertification { get; }
        
        LayoutList<LoopL1_304> LoopL1 { get; }
    }
}