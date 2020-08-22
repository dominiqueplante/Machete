namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0350_204Map :
        X12LayoutMap<Loop0350_204, X12Entity>
    {
        public Loop0350_204Map()
        {
            Id = "Loop_0350_204";
            Name = "Loop 0350";
            
            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.DateOrTime, 1);
            Segment(x => x.LadingDetail, 2);
            Layout(x => x.Loop0360, 3);
        }
    }
}