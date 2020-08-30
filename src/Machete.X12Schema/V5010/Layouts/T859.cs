namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T859 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B3> BeginningSegmentForCarrierInvoice { get; }
        
        Segment<B3A> InvoiceType { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
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
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<PS> ProtectiveServicesInstructions { get; }
        
        SegmentList<H6> SpecialServices { get; }
        
        Segment<M1> Insurance { get; }
        
        Segment<M2> SalesOrDeliveryTerms { get; }
        
        Segment<L7> TariffReference { get; }
        
        SegmentList<NTE> NoteOrSpecialInstruction { get; }
        
        Segment<XH> ProFormaB13Information { get; }
        
        SegmentList<P1> Pickup { get; }
        
        Segment<ITA> AllowanceChargeOrService { get; }
        
        SegmentList<N8> WaybillReference { get; }
        
        Segment<R9> RouteCodeIdentification { get; }
        
        LayoutList<LoopH1_859> LoopH1 { get; }
        
        LayoutList<LoopN7_859> LoopN7 { get; }
        
        LayoutList<LoopN1_859> LoopN1 { get; }
        
        LayoutList<LoopS5_859> LoopS5 { get; }
        
        LayoutList<LoopLX_859> LoopLX { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}