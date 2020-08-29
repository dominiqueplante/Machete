namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class A997Map :
        X12LayoutMap<A997, X12Entity>
    {
        public A997Map()
        {
            Id = "A997";
            Name = "997 Functional Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0, x => x.IsRequired());
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}