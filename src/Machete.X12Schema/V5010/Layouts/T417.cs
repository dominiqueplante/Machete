namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T417 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }
        
        Segment<ZC1> BeginningDataCorrectionOrChange { get; }
        
        Segment<BX> GeneralShipmentInformation { get; }
        
        Segment<BNX> RailShipmentInformation { get; }
        
        Segment<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<CM> CargoManifest { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopN7_417> LoopN7 { get; }
        
        SegmentList<N8> WaybillReference { get; }

        Segment<N8A> AdditionalReferenceInformation { get; }
        
        Segment<V9> EventDetail { get; }
        
        Segment<F9> OriginStation { get; }
        
        Segment<D9> DestinationStation { get; }
        
        LayoutList<LoopN1_3_417> LoopN1 { get; }
        
        LayoutList<LoopS1_417> LoopS1 { get; }
        
        SegmentList<R2> RouteInformation { get; }
        
        Segment<R9> RouteCodeIdentification { get; }
        
        LayoutList<LoopE1_417> LoopE1 { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<PS> ProtectiveServicesInstructions { get; }
        
        LayoutList<LoopLX_417> LoopLX { get; }
        
        LayoutList<LoopT1_417> LoopT1 { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<LoopLH1_417> LoopLH1 { get; }
        
        Segment<LE> LoopTrailer { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<LH2> HazardousClassificationInformation { get; }
        
        SegmentList<LHR> HazardousMaterialIdentifyingReferenceNumbers { get; }
        
        Segment<XH> ProFormaB13Information { get; }
        
        SegmentList<X7> CustomsInformation { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}