namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0100_894Map :
        X12LayoutMap<Loop0100_894, X12Entity>
    {
        public Loop0100_894Map()
        {
            Id = "Loop_0100_894";
            Name = "Loop 0100";
            
            Segment(x => x.LineItemDetailDirectStoreDelivery, 0);
            Segment(x => x.PrePricingInformation, 1);
            Segment(x => x.AllowanceOrCharge, 2);
            Segment(x => x.TermsOfSale, 3);
        }
    }
}