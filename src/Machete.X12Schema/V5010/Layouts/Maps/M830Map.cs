namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M830Map :
        X12LayoutMap<M830, X12Entity>
    {
        public M830Map()
        {
            Id = "M830";
            Name = "830 Planning Schedule with Release Capability";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}