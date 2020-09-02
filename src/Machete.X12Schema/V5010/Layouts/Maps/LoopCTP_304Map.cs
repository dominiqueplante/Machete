namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTP_304Map :
        X12LayoutMap<LoopCTP_304, X12Entity>
    {
        public LoopCTP_304Map()
        {
            Id = "Loop_CTP_304";
            Name = "Loop CTP";
            
            Segment(x => x.PricingInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}