namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Y5Map :
        X12SegmentMap<Y5, X12Entity>
    {
        public Y5Map()
        {
            Id = "Y5";
            Name = "Space Booking Cancellation";
            
            Value(x => x.BookingNumber, 1, x => x.MinLength(1).MaxLength(17).IsRequired());
        }
    }
}