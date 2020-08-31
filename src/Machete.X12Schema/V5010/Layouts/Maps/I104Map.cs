namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I104Map :
        X12LayoutMap<I104, X12Entity>
    {
        public I104Map()
        {
            Id = "I104";
            Name = "104 Air Shipment Information";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}