namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I310Map :
        X12LayoutMap<I310, X12Entity>
    {
        public I310Map()
        {
            Id = "I310";
            Name = "310 Freight Receipt and Invoice (Ocean)";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}