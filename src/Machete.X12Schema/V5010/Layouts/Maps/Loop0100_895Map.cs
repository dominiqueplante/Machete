namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0100_895Map :
        X12LayoutMap<Loop0100_895, X12Entity>
    {
        public Loop0100_895Map()
        {
            Id = "Loop_0100_895";
            Name = "Loop 0100";
            
            Segment(x => x.LineItemDetailDirectStoreDelivery, 0);
            Segment(x => x.PrePricingInformation, 1);
            Segment(x => x.AllowanceOrCharge, 2);
            Segment(x => x.TermsOfSale, 3);
        }
    }
}