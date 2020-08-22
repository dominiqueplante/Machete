namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0250_210Map :
        X12LayoutMap<Loop0250_210, X12Entity>
    {
        public Loop0250_210Map()
        {
            Id = "Loop_0250_210";
            Name = "Loop 0250";
            
            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.DestinationQuantity, 1);
        }
    }
}