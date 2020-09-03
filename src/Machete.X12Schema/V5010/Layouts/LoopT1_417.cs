namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopT1_417 :
        X12Layout
    {
        Segment<T1> TransitInboundOrigin { get; }
        
        SegmentList<T2> TransitInboundLading { get; }
        
        SegmentList<T3> TransitInboundRoute { get; }
        
        Segment<T6> TransitInboundRates { get; }
        
        SegmentList<T8> FreeformTransitData { get; }
    }
}