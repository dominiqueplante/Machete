namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopG39_832Map :
        X12LayoutMap<LoopG39_832, X12Entity>
    {
        public LoopG39_832Map()
        {
            Id = "Loop_G39_832";
            Name = "Loop G39";
            
            Segment(x => x.ItemCharacteristicsVendorSellingUnit, 0);
            Segment(x => x.PricingInformation, 1);
            Segment(x => x.MarkingPackagingOrLoading, 2);
            Segment(x => x.MaintenanceType, 3);
            Segment(x => x.DateOrTimeReference, 4);
        }
    }
}