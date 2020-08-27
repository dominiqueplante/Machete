namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopG40_832Map :
        X12LayoutMap<LoopG40_832, X12Entity>
    {
        public LoopG40_832Map()
        {
            Id = "Loop_G40_832";
            Name = "Loop G40";
            
            Segment(x => x.BracketPrice, 0);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 1);
            Segment(x => x.PriceBracketIdentification, 2);
        }
    }
}