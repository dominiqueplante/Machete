namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I204Map :
        X12LayoutMap<I204, X12Entity>
    {
        public I204Map()
        {
            Id = "I204";
            Name = "204 Motor Carrier Load Tender";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}