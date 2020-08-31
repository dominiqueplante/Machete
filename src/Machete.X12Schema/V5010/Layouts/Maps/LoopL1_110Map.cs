namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL1_110Map :
        X12LayoutMap<LoopL1_110, X12Entity>
    {
        public LoopL1_110Map()
        {
            Id = "Loop_L1_110";
            Name = "Loop L1";
            
            Segment(x => x.RateAndCharges, 0);
            Segment(x => x.CurrencyIdentifier, 1);
        }
    }
}