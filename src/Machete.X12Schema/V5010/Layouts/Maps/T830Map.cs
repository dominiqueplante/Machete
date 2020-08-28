namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T830Map :
        X12LayoutMap<T830, X12Entity>
    {
        public T830Map()
        {
            Id = "T830";
            Name = "855 Purchase Order Acknowledgement";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForPlanningSchedule, 2);
            Segment(x => x.PreassignedPurchaseOrderNumbers, 3);
            Segment(x => x.Currency, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Segment(x => x.TaxReference, 7);
            Segment(x => x.FreeOnBoardRelatedInstructions, 8);
            Segment(x => x.PricingInformation, 9);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 10);
            Segment(x => x.SalesRequirements, 11);
            Segment(x => x.TermsOfSale, 12);
            Segment(x => x.DateOrTimeReference, 13);
            Segment(x => x.ProductOrItemDescription, 14);
            Segment(x => x.Measurements, 16);
            Segment(x => x.Paperwork, 17);
            Segment(x => x.MarkingPackagingOrLoading, 18);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 19);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 20);
            Segment(x => x.CarrierDetailsEquipment, 21);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 22);
            Segment(x => x.MarksAndNumbersInformation, 23);
            Layout(x => x.LoopN1, 24);
            Layout(x => x.LoopLM, 25);
            Layout(x => x.LoopLIN, 26);
            Segment(x => x.TransactionTotals, 34);
            Segment(x => x.TransactionSetTrailer, 35);
            Segment(x => x.FunctionalGroupTrailer, 36);
        }
    }
}