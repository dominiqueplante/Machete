namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I214Map :
        X12LayoutMap<I214, X12Entity>
    {
        public I214Map()
        {
            Id = "I214";
            Name = "214 Transportation Carrier Shipment Status Message";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}