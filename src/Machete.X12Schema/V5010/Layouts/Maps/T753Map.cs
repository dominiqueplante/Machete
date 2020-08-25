namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T753Map :
        X12LayoutMap<T753, X12Entity>
    {
        public T753Map()
        {
            Id = "T753";
            Name = "753 Request for Routing Instructions";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningTransportationCarrierShipmentStatusMessage, 2);
            Segment(x => x.AdministrativeCommunicationsContact, 3);
            Layout(x => x.Loop0100, 4);
            Segment(x => x.TransactionSetLineNumber, 5);
            Layout(x => x.Loop0200, 6);
            Segment(x => x.TransactionSetTrailer, 7);
            Segment(x => x.FunctionalGroupTrailer, 8);
        }
    }
}