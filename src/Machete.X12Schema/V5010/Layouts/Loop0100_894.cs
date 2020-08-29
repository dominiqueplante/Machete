namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0100_894 :
        X12Layout
    {
        Segment<G83> LineItemDetailDirectStoreDelivery { get; }

        Segment<G22> PrePricingInformation { get; }
        
        SegmentList<G72> AllowanceOrCharge { get; }

        SegmentList<G23> TermsOfSale { get; }
    }
}