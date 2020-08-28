namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLIN_830Map :
        X12LayoutMap<LoopLIN_830, X12Entity>
    {
        public LoopLIN_830Map()
        {
            Id = "Loop_LIN_830";
            Name = "Loop LIN";
            
            Segment(x => x.ItemIdentification, 0);
            Segment(x => x.UnitDetail, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.AdditionalItemDetail, 4);
            Segment(x => x.PricingInformation, 5);
            Segment(x => x.ProductOrItemDescription, 6);
            Segment(x => x.Measurements, 7);
            Segment(x => x.Paperwork, 8);
            Segment(x => x.MarkingPackagingOrLoading, 9);
            Segment(x => x.ItemPhysicalDetails, 10);
            Segment(x => x.PartReleaseStatus, 11);
            Segment(x => x.ReferenceInformation, 12);
            Segment(x => x.AdministrativeCommunicationsContact, 13);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 14);
            Segment(x => x.TermsOfSale, 15);
            Segment(x => x.TaxReference, 16);
            Segment(x => x.FreeOnBoardRelatedInstructions, 17);
            Segment(x => x.LeadTime, 18);
            Segment(x => x.QuantityInformation, 19);
            Segment(x => x.ResourceAuthorization, 20);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 21);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 22);
            Segment(x => x.CarrierDetailsEquipment, 23);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 24);
            Segment(x => x.MarksAndNumbersInformation, 25);
            Segment(x => x.DemandDetail, 26);
            Layout(x => x.LoopSLN, 27);
            Layout(x => x.LoopN1, 28);
            Layout(x => x.LoopLM, 29);
            Layout(x => x.LoopFST, 30);
            Layout(x => x.LoopSDP, 31);
            Layout(x => x.LoopSHP, 32);
        }
    }
}