namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M754Map :
        X12LayoutMap<M754, X12Entity>
    {
        public M754Map()
        {
            Id = "M754";
            Name = "754 Routing Instructions";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}