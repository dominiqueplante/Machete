namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I315Map :
        X12LayoutMap<I315, X12Entity>
    {
        public I315Map()
        {
            Id = "I315";
            Name = "315 Status Details (Ocean)";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}