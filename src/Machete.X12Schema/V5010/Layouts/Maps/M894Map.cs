namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M894Map :
        X12LayoutMap<M894, X12Entity>
    {
        public M894Map()
        {
            Id = "M894";
            Name = "894 Delivery/Return Base Record";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}