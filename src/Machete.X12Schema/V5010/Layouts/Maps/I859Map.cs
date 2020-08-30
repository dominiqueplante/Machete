namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I859Map :
        X12LayoutMap<I859, X12Entity>
    {
        public I859Map()
        {
            Id = "I859";
            Name = "859 Freight Invoice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}