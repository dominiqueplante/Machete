namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T303Map :
        X12LayoutMap<T303, X12Entity>
    {
        public T303Map()
        {
            Id = "T303";
            Name = "303 Booking Cancellation (Ocean)";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForBookingOrPickupDelivery, 2);
            Segment(x => x.Authentication, 3);
            Segment(x => x.SpaceBookingCancellation, 4);
            Segment(x => x.EventDetail, 5);
            Segment(x => x.TransactionSetTrailer, 6);
            Segment(x => x.FunctionalGroupTrailer, 7);
        }
    }
}