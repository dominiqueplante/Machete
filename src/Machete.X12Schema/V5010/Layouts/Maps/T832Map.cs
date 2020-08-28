namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T832Map :
        X12LayoutMap<T832, X12Entity>
    {
        public T832Map()
        {
            Id = "T846";
            Name = "832 Price/Sales Catalog";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForPriceOrSalesCatalog, 2);
            Segment(x => x.PricingInformation, 3);
            Segment(x => x.ReferenceInformation, 4);
            Segment(x => x.YesNoQuestion, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Segment(x => x.RestrictionsOrConditions, 8);
            Segment(x => x.Currency, 9);
            Segment(x => x.TermsOfSale, 10);
            Segment(x => x.LeadTime, 11);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 12);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 13);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 14);
            Segment(x => x.CarrierDetailsEquipment, 15);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 16);
            Segment(x => x.FreeOnBoardRelatedInstructions, 17);
            Segment(x => x.MarkingPackagingOrLoading, 18);
            Segment(x => x.TaxInformation, 19);
            Segment(x => x.RequestValidation, 20);
            Segment(x => x.Paperwork, 21);
            Segment(x => x.Text, 22);
            Layout(x => x.LoopN1, 23);
            Layout(x => x.LoopLM, 24);
            Layout(x => x.LoopN9, 25);
            Layout(x => x.LoopG93, 26);
            Layout(x => x.LoopLIN, 27);
            Segment(x => x.TransactionTotals, 28);
            Segment(x => x.TransactionSetTrailer, 29);
            Segment(x => x.FunctionalGroupTrailer, 30);
        }
    }
}