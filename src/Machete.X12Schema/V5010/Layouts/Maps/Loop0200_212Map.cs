namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_212Map :
        X12LayoutMap<Loop0200_212, X12Entity>
    {
        public Loop0200_212Map()
        {
            Id = "Loop_0200_212";
            Name = "Loop 0200";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.ShipmentStatusDetails, 2);
            Segment(x => x.TransportationCarrierIdentification, 3);
            Segment(x => x.MarksAndNumbersInformation, 4);
            Segment(x => x.ShipmentWeightPackagingAndQuantityData, 5);
            Segment(x => x.LadingExceptionStatus, 6);
            Segment(x => x.DateOrTime, 7);
            Segment(x => x.TrailerShipmentDetails, 8);
            Layout(x => x.Loop0210, 9);
            Layout(x => x.Loop0220, 10);
        }
    }
}