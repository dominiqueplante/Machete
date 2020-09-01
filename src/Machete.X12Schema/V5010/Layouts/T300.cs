namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T300 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B1> BeginningSegmentForBookingOrPickupDelivery { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<Y6> Authentication { get; }
        
        Segment<Y7> CargoBookingPriority { get; }
        
        Segment<Y1> SpaceReservationRequest { get; }
        
        LayoutList<LoopY2_300> LoopY2 { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<R2A> RouteInformationWithPreference { get; }
        
        LayoutList<LoopN1_300> LoopN1 { get; }
        
        LayoutList<LoopR4_300> LoopR4 { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<EA> EquipmentAttributes { get; }
        
        LayoutList<LoopLX_300> LoopLX { get; }
        
        SegmentList<V1> VesselIdentification { get; }
        
        SegmentList<V9> EventDetail { get; }
        
        SegmentList<K1> Remarks { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}