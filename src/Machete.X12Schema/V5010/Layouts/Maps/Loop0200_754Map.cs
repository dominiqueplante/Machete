namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_754Map :
        X12LayoutMap<Loop0200_754, X12Entity>
    {
        public Loop0200_754Map()
        {
            Id = "Loop_0200_754";
            Name = "Loop 0200";

            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.TransportationCarrierIdentification, 2);
            Segment(x => x.ConsolidatedShipmentManifestData, 3);
            Segment(x => x.OrderInformationDetail, 4);
            Segment(x => x.DateOrTime, 5);
            Segment(x => x.EquipmentShipmentOrRealPropertyLocation, 6);
            Layout(x => x.Loop0210, 7);
            Layout(x => x.Loop0220, 8);
        }
    }
}