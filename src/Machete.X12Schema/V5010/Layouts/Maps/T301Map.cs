namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T301Map :
        X12LayoutMap<T301, X12Entity>
    {
        public T301Map()
        {
            Id = "T301";
            Name = "301 Confirmation (Ocean)";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForBookingOrPickupDelivery, 2);
            Segment(x => x.Contact, 3);
            Segment(x => x.Authentication, 4);
            Segment(x => x.SpaceConfirmation, 5);
            Layout(x => x.LoopY4, 6);
            Segment(x => x.ExtendedReferenceInformation, 7);
            Segment(x => x.RouteInformationWithPreference, 8);
            Layout(x => x.LoopN1, 9);
            Layout(x => x.LoopR4, 10);
            Segment(x => x.EquipmentAndTemperature, 11);
            Segment(x => x.SpecialHandlingInstructions, 12);
            Segment(x => x.EquipmentAttributes, 13);
            Layout(x => x.LoopLX, 14);
            Segment(x => x.VesselIdentification, 15);
            Segment(x => x.EventDetail, 16);
            Segment(x => x.TransactionSetTrailer, 17);
            Segment(x => x.FunctionalGroupTrailer, 18);
        }
    }
}