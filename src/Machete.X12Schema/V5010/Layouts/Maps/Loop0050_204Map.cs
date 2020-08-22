namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0050_204Map :
        X12LayoutMap<Loop0050_204, X12Entity>
    {
        public Loop0050_204Map()
        {
            Id = "Loop_0050_204";
            Name = "Loop 0050";
            
            Segment(x => x.BillOfLadingHandlingRequirements, 0);
            Segment(x => x.FreightRateInformation, 1);
            Segment(x => x.CurrencyIdentifier, 2);
        }
    }
}