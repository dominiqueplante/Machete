namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSDP_830Map :
        X12LayoutMap<LoopSDP_830, X12Entity>
    {
        public LoopSDP_830Map()
        {
            Id = "Loop_SDP_830";
            Name = "Loop SDP";
            
            Segment(x => x.ShipOrDeliveryPattern, 0);
            Segment(x => x.ForecastSchedule, 1);
        }
    }
}