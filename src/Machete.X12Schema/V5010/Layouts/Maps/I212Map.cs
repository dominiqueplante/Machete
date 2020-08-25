namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I212Map :
        X12LayoutMap<I212, X12Entity>
    {
        public I212Map()
        {
            Id = "I212";
            Name = "212 - Motor Carrier Delivery Trailer Manifest";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}