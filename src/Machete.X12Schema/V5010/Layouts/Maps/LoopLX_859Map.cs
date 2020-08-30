namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_859Map :
        X12LayoutMap<LoopLX_859, X12Entity>
    {
        public LoopLX_859Map()
        {
            Id = "Loop_LX_859";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Layout(x => x.LoopN1, 1);
            Segment(x => x.DescriptionMarksAndNumbers, 2);
            Layout(x => x.LoopL0, 3);
            Segment(x => x.TariffReference, 4);
            Segment(x => x.TariffDetails, 5);
            Segment(x => x.RouteInformationAir, 6);
            Segment(x => x.MixedHazardousCommodities, 7);
            Segment(x => x.ExtendedReferenceInformation, 8);
            Segment(x => x.ExportLicense, 9);
            Segment(x => x.ImportLicense, 10);
            Segment(x => x.Pickup, 11);
            Segment(x => x.ProofOfDelivery, 12);
            Segment(x => x.FreeOnBoardRelatedInstructions, 13);
            Segment(x => x.AllowanceChargeOrService, 14);
            Segment(x => x.LineItemSubtotal, 16);
            Segment(x => x.EventDetail, 17);
            Segment(x => x.DeliveryDateInformation, 18);
            Segment(x => x.EquipmentDetails, 19);
            Layout(x => x.LoopLX, 20);
        }
    }
}