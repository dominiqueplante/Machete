namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I410Map :
        X12LayoutMap<I410, X12Entity>
    {
        public I410Map()
        {
            Id = "I410";
            Name = "410 Rail Carrier Freight Details and Invoice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}