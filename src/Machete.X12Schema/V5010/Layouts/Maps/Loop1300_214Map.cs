namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1300_214Map :
        X12LayoutMap<Loop1300_214, X12Entity>
    {
        public Loop1300_214Map()
        {
            Id = "Loop_1300_214";
            Name = "Loop 1300";
            
            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.DestinationQuantity, 1);
        }
    }
}