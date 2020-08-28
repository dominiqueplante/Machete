namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFST_830Map :
        X12LayoutMap<LoopFST_830, X12Entity>
    {
        public LoopFST_830Map()
        {
            Id = "Loop_FST_830";
            Name = "Loop SDP";
            
            Segment(x => x.ForecastSchedule, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.DestinationQuantity, 2);
            Layout(x => x.LoopLM, 3);
        }
    }
}