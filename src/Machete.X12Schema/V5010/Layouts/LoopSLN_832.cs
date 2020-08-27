namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_832 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        Segment<PID> ItemDescription { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<MTX> Text { get; }
        
        LayoutList<LoopLM_1_832> LoopLM { get; }
        
        LayoutList<LoopN1_4_832> LoopN1 { get; }
    }
}