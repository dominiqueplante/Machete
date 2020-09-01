namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T300Map :
        X12LayoutMap<T300, X12Entity>
    {
        public T300Map()
        {
            Id = "T300";
            Name = "300 Reservation (Booking Request) (Ocean)";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForBookingOrPickupDelivery, 2);
            Segment(x => x.Contact, 3);
            Segment(x => x.Authentication, 4);
            Segment(x => x.CargoBookingPriority, 5);
            Segment(x => x.SpaceReservationRequest, 6);
            Layout(x => x.LoopY2, 7);
            Segment(x => x.ExtendedReferenceInformation, 8);
            Segment(x => x.RouteInformationWithPreference, 9);
            Layout(x => x.LoopN1, 10);
            Layout(x => x.LoopR4, 11);
            Segment(x => x.EquipmentAndTemperature, 12);
            Segment(x => x.SpecialHandlingInstructions, 13);
            Segment(x => x.EquipmentAttributes, 14);
            Layout(x => x.LoopLX, 15);
            Segment(x => x.VesselIdentification, 16);
            Segment(x => x.EventDetail, 17);
            Segment(x => x.Remarks, 18);
            Segment(x => x.TransactionSetTrailer, 19);
            Segment(x => x.FunctionalGroupTrailer, 20);
        }
    }
}