namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopG93_832Map :
        X12LayoutMap<LoopG93_832, X12Entity>
    {
        public LoopG93_832Map()
        {
            Id = "Loop_G93_832";
            Name = "Loop G93";
            
            Segment(x => x.PriceBracketIdentification, 0);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 1);
            Segment(x => x.PartyIdentification, 2);
            Segment(x => x.PricingConditions, 3);
        }
    }
}