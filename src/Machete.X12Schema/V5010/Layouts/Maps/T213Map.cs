namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T213Map :
        X12LayoutMap<T213, X12Entity>
    {
        public T213Map()
        {
            Id = "T213";
            Name = "213 Motor Carrier Shipment Status Inquiry";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningShipmentStatusInquiry, 2);
            Segment(x => x.CurrencyIdentifier, 3);
            Segment(x => x.ReferenceInformation, 4);
            Segment(x => x.WeightInformation, 5);
            Layout(x => x.Loop0100, 6);
            Segment(x => x.AdministrativeMessage, 7);
            Segment(x => x.TransactionSetTrailer, 8);
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}