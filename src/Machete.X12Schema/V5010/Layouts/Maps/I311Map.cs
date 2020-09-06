namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I311Map :
        X12LayoutMap<I311, X12Entity>
    {
        public I311Map()
        {
            Id = "I311";
            Name = "311 Canada Customs Information";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}