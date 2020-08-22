namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0305_210Map :
        X12LayoutMap<Loop0305_210, X12Entity>
    {
        public Loop0305_210Map()
        {
            Id = "Loop_0305_210";
            Name = "Loop 0305";
            
            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.DestinationQuantity, 1);
        }
    }
}