namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPKL_832 :
        X12Layout
    {
        Segment<PKL> MultiPackConfiguration { get; }
        
        Segment<CTP> PricingInformation { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        Segment<G53> MaintenanceType { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}