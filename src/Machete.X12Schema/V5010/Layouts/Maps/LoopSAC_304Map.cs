namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_304Map :
        X12LayoutMap<LoopSAC_304, X12Entity>
    {
        public LoopSAC_304Map()
        {
            Id = "Loop_SAC_304";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}