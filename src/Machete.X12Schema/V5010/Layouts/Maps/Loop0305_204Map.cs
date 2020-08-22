namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0305_204Map :
        X12LayoutMap<Loop0305_204, X12Entity>
    {
        public Loop0305_204Map()
        {
            Id = "Loop_0305_204";
            Name = "Loop 0305";
            
            Segment(x => x.BillOfLadingHandlingRequirements, 0);
            Segment(x => x.FreightRateInformation, 1);
            Segment(x => x.CurrencyIdentifier, 2);
        }
    }
}