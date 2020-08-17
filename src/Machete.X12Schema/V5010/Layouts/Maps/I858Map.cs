namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I858Map :
        X12LayoutMap<I858, X12Entity>
    {
        public I858Map()
        {
            Id = "I858";
            Name = "858 Shipment Information";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}