namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M832Map :
        X12LayoutMap<M832, X12Entity>
    {
        public M832Map()
        {
            Id = "M832";
            Name = "846 Inventory Inquiry/Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}