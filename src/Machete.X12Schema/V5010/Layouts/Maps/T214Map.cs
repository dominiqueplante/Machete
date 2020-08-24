namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T214Map :
        X12LayoutMap<T214, X12Entity>
    {
        public T214Map()
        {
            Id = "T214";
            Name = "214 Transportation Carrier Shipment Status Message";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningTransportationCarrierShipmentStatusMessage, 2);
            Segment(x => x.InterlineInformation, 3);
            Layout(x => x.Loop1000, 4);
            Segment(x => x.TransactionSetTrailer, 5);
            Segment(x => x.FunctionalGroupTrailer, 6);
        }
    }
}