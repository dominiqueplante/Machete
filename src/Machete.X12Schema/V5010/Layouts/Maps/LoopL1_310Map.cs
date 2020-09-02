namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL1_310Map :
        X12LayoutMap<LoopL1_310, X12Entity>
    {
        public LoopL1_310Map()
        {
            Id = "Loop_L1_310";
            Name = "Loop C8";
            
            Segment(x => x.RateAndCharges, 0);
            Segment(x => x.CurrencyIdentifier, 1);
        }
    }
}