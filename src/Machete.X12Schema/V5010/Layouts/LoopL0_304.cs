namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL0_304 :
        X12Layout
    {
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        LayoutList<LoopPO4_304> LoopPO4 { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        Segment<L4> Measurement { get; }
        
        SegmentList<LH6> HazardousCertification { get; }
        
        LayoutList<LoopPAL_304> LoopPAL { get; }
        
        LayoutList<LoopCTP_304> LoopCTP { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        Segment<LIN> ItemIdentification { get; }
        
        Segment<L12> AlternateLadingDescription { get; }
        
        SegmentList<YNQ> YesNoQuestion { get; }
        
        LayoutList<LoopL1_304> LoopL1 { get; }
        
        Segment<L7> TariffReference { get; }
        
        LayoutList<LoopSAC_304> LoopSAC { get; }
        
        LayoutList<LoopL9_304> LoopL9 { get; }
        
        SegmentList<X1> ExportLicense { get; }
        
        SegmentList<X2> ImportLicense { get; }
        
        LayoutList<LoopC8_304> LoopC8 { get; }
        
        LayoutList<LoopH1_304> LoopH1 { get; }
        
        LayoutList<LoopLH1_304> LoopLH1 { get; }
        
        LayoutList<LoopN1_304> LoopN1 { get; }
    }
}