namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T301 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B1> BeginningSegmentForBookingOrPickupDelivery { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<Y6> Authentication { get; }
        
        Segment<Y3> SpaceConfirmation { get; }
        
        LayoutList<LoopY4_301> LoopY4 { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<R2A> RouteInformationWithPreference { get; }
        
        LayoutList<LoopN1_301> LoopN1 { get; }
        
        LayoutList<LoopR4_301> LoopR4 { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<EA> EquipmentAttributes { get; }
        
        LayoutList<LoopLX_301> LoopLX { get; }
        
        SegmentList<V1> VesselIdentification { get; }
        
        SegmentList<V9> EventDetail { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}