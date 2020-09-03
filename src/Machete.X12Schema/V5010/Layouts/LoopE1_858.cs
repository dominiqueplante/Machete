namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopE1_858 :
        X12Layout
    {
        Segment<E1> EmptyCarDispositionPendedDestinationConsignee { get; }
        
        Segment<E4> EmptyCarDispositionPendedDestinationCity { get; }
        
        SegmentList<E5> EmptyCarDispositionPendedDestinationRoute { get; }
        
        Segment<PI> PriceAuthorityIdentification { get; }
    }
}