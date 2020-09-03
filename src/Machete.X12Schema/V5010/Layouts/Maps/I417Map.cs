namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I417Map :
        X12LayoutMap<I417, X12Entity>
    {
        public I417Map()
        {
            Id = "I417";
            Name = "417 Rail Carrier Waybill Interchange";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}