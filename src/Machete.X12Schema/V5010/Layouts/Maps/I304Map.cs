namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I304Map :
        X12LayoutMap<I304, X12Entity>
    {
        public I304Map()
        {
            Id = "I304";
            Name = "304 Shipping Instructions";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}