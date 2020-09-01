namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T303 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B1> BeginningSegmentForBookingOrPickupDelivery { get; }
        
        SegmentList<Y6> Authentication { get; }
        
        Segment<Y5> SpaceBookingCancellation { get; }
        
        SegmentList<V9> EventDetail { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}