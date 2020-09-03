namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T410 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B3B> BeginningSegmentForRailCarrierInvoice { get; }
        
        Segment<C4> AlternateAmountDue { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<CM> CargoManifest { get; }
        
        SegmentList<NTE> NoteOrSpecialInstruction { get; }
        
        LayoutList<LoopN7_410> LoopN7 { get; }
        
        SegmentList<N8> WaybillReference { get; }
        
        Segment<F9> OriginStation { get; }
        
        Segment<D9> DestinationStation { get; }
        
        LayoutList<LoopN1_410> LoopN1 { get; }
        
        LayoutList<LoopS1_410> LoopS1 { get; }
        
        SegmentList<R2> RouteInformation { get; }
        
        Segment<R9> RouteCodeIdentification { get; }
        
        SegmentList<PS> ProtectiveServicesInstructions { get; }
        
        LayoutList<LoopLX_410> LoopLX { get; }
        
        LayoutList<LoopT1_410> LoopT1 { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        SegmentList<X7> CustomsInformation { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}