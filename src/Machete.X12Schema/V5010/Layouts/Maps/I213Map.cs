namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I213Map :
        X12LayoutMap<I213, X12Entity>
    {
        public I213Map()
        {
            Id = "I213";
            Name = "213 Motor Carrier Shipment Status Inquiry";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}