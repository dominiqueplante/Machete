namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTP_832Map :
        X12LayoutMap<LoopCTP_832, X12Entity>
    {
        public LoopCTP_832Map()
        {
            Id = "Loop_CTP_832";
            Name = "Loop CTP";
            
            Segment(x => x.PricingInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.PriceListReference, 2);
            Segment(x => x.LeadTime, 3);
            Segment(x => x.Currency, 4);
            Segment(x => x.ItemPhysicalDetails, 5);
            Segment(x => x.RestrictionsOrConditions, 6);
            Segment(x => x.ReferenceInformation, 7);
            Segment(x => x.PromotionOrPriceListArea, 8);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 9);
            Segment(x => x.PricingConditions, 10);
            Segment(x => x.TaxInformation, 11);
            Segment(x => x.TermsOfSale, 12);
            Layout(x => x.LoopG40, 13);
            Segment(x => x.LoopHeader, 14);
            Layout(x => x.LoopLM, 15);
            Segment(x => x.LoopTrailer, 16);
            Layout(x => x.LoopN1, 17);
        }
    }
}