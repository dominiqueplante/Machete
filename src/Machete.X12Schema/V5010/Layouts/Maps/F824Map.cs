namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F824Map :
        X12LayoutMap<F824, X12Entity>
    {
        public F824Map()
        {
            Id = "F824";
            Name = "824 Application Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}