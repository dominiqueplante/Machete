namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPKL_832Map :
        X12LayoutMap<LoopPKL_832, X12Entity>
    {
        public LoopPKL_832Map()
        {
            Id = "Loop_PKL_832";
            Name = "Loop PKL";
            
            Segment(x => x.MultiPackConfiguration, 0);
            Segment(x => x.PricingInformation, 1);
            Segment(x => x.MarkingPackagingOrLoading, 2);
            Segment(x => x.MaintenanceType, 3);
            Segment(x => x.DateOrTimeReference, 4);
        }
    }
}