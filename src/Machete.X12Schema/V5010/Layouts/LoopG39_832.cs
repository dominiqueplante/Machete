namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopG39_832 :
        X12Layout
    {
        Segment<G39> ItemCharacteristicsVendorSellingUnit { get; }
        
        Segment<CTP> PricingInformation { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<G53> MaintenanceType { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}