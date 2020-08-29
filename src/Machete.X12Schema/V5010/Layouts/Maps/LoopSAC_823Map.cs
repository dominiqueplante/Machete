namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_823Map :
        X12LayoutMap<LoopSAC_823, X12Entity>
    {
        public LoopSAC_823Map()
        {
            Id = "Loop_SAC_823";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.TaxInformation, 1);
        }
    }
}