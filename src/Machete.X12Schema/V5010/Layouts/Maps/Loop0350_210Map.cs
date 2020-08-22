namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0350_210Map :
        X12LayoutMap<Loop0350_210, X12Entity>
    {
        public Loop0350_210Map()
        {
            Id = "Loop_0350_210";
            Name = "Loop 0350";
            
            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.DestinationQuantity, 1);
        }
    }
}