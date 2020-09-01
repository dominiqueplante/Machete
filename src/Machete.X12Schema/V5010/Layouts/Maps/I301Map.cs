namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I301Map :
        X12LayoutMap<I301, X12Entity>
    {
        public I301Map()
        {
            Id = "I301";
            Name = "301 Confirmation (Ocean)";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}