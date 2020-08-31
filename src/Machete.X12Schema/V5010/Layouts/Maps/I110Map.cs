namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I110Map :
        X12LayoutMap<I110, X12Entity>
    {
        public I110Map()
        {
            Id = "I110";
            Name = "110 Air Freight Details and Invoice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}