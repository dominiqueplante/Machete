namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0325_1_204Map :
        X12LayoutMap<Loop0325_1_204, X12Entity>
    {
        public Loop0325_1_204Map()
        {
            Id = "Loop_0325_1_204";
            Name = "Loop 0325";
            
            Segment(x => x.BillOfLadingHandlingRequirements, 0);
            Segment(x => x.FreightRateInformation, 1);
            Segment(x => x.CurrencyIdentifier, 2);
        }
    }
}