namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T858 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<ZC1> BeginningDataCorrectionOrChange { get; }
        
        Segment<BX> GeneralShipmentInformation { get; }
        
        Segment<BNX> RailShipmentInformation { get; }
        
        Segment<M3> Release { get; }
        
        Segment<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<CM> CargoManifest { get; }
        
        SegmentList<Y6> Authentication { get; }
        
        Segment<Y7> CargoBookingPriority { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
        
        Segment<ITD> TermsOfSale { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<NA> CrossReferenceEquipment { get; }
        
        Segment<F9> OriginStation { get; }
        
        Segment<D9> DestinationStation { get; }
        
        Segment<R1> RouteInformationAir { get; }
        
        SegmentList<R2> RouteInformation { get; }
        
        SegmentList<R3> RouteInformationMotor { get; }
        
        SegmentList<R4> PortOrTerminal { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<PS> ProtectiveServicesInstructions { get; }
        
        SegmentList<H6> SpecialServices { get; }
        
        Segment<V4> CargoLocationReference { get; }
        
        Segment<V5> VesselIdentification { get; }
        
        LayoutList<LoopE1_858> LoopE1 { get; }
        
        Segment<M1> Insurance { get; }
        
        Segment<M2> SalesOrDeliveryTerms { get; }
        
        Segment<L7> TariffReference { get; }
        
        SegmentList<NTE> NoteOrSpecialInstruction { get; }
        
        Segment<XH> ProFormaB13Information { get; }
        
        LayoutList<LoopN7_858> LoopN7 { get; }
        
        LayoutList<LoopN1_1_858> LoopN1 { get; }
        
        LayoutList<LoopS5_858> LoopS5 { get; }
        
        LayoutList<LoopFA1_858> LoopFA1 { get; }
        
        LayoutList<LoopHL_858> LoopHL { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}