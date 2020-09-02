namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL1_304Map :
        X12LayoutMap<LoopL1_304, X12Entity>
    {
        public LoopL1_304Map()
        {
            Id = "Loop_L1_304";
            Name = "Loop L1";
            
            Segment(x => x.RateAndCharges, 0);
            Segment(x => x.Currency, 1);
        }
    }
}