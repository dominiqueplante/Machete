namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F831Map :
        X12LayoutMap<F831, X12Entity>
    {
        public F831Map()
        {
            Id = "F831";
            Name = "831 Application Control Totals";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}