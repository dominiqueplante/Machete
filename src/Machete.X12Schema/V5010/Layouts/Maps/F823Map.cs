namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F823Map :
        X12LayoutMap<F823, X12Entity>
    {
        public F823Map()
        {
            Id = "F823";
            Name = "823 Lockbox";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}