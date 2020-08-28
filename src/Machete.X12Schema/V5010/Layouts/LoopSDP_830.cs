namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSDP_830 :
        X12Layout
    {
        Segment<SDP> ShipOrDeliveryPattern { get; }
        
        SegmentList<FST> ForecastSchedule { get; }
    }
}