namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLIN_832Map :
        X12LayoutMap<LoopLIN_832, X12Entity>
    {
        public LoopLIN_832Map()
        {
            Id = "Loop_LIN_832";
            Name = "Loop LIN";
            
            Segment(x => x.ItemIdentification, 0);
            Segment(x => x.BaselineItemData, 1);
            Segment(x => x.MaintenanceType, 2);
            Segment(x => x.ServiceCharacteristicIdentification, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Segment(x => x.ReferenceIdentification, 5);
            Segment(x => x.YesOrNoQuestion, 6);
            Segment(x => x.AdministrativeCommunicationsContact, 7);
            Segment(x => x.ContentReportingDetail, 8);
            Segment(x => x.RestrictionsOrConditions, 9);
            Segment(x => x.ProductOrItemDescription, 10);
            Segment(x => x.Measurements, 11);
            Segment(x => x.MarkingPackagingOrLoading, 12);
            Segment(x => x.ItemPhysicalDetails, 13);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 14);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 15);
            Segment(x => x.CarrierDetailsEquipment, 16);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 17);
            Segment(x => x.TermsOfSale, 18);
            Segment(x => x.LeadTime, 19);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 20);
            Segment(x => x.FreeOnBoardRelatedInstructions, 21);
            Segment(x => x.RequestValidation, 22);
            Segment(x => x.Commodity, 23);
            Segment(x => x.TaxInformation, 24);
            Segment(x => x.Text, 25);
            Segment(x => x.ItemCharacteristicsConsumerUnit, 26);
            Segment(x => x.ModuleDescription, 27);
            Segment(x => x.TrailerShipmentDetails, 28);
            Layout(x => x.LoopCTP, 29);
            Layout(x => x.LoopN1, 30);
            Layout(x => x.LoopG39, 31);
            Layout(x => x.LoopPKL, 32);
            Layout(x => x.LoopLFG, 33);
            Layout(x => x.LoopLM, 34);
            Layout(x => x.LoopSLN, 35);
            Layout(x => x.LoopN9, 36);
        }
    }
}