namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0465_210Map :
        X12LayoutMap<Loop0465_210, X12Entity>
    {
        public Loop0465_210Map()
        {
            Id = "Loop_0465_210";
            Name = "Loop 0465";
            
            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.DestinationQuantity, 1);
        }
    }
}