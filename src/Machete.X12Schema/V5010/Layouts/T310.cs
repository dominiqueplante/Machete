namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T310 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B3> BeginningSegmentForCarrierInvoice { get; }
        
        Segment<B2A> SetPurpose { get; }
        
        SegmentList<Y6> Authentication { get; }
        
        SegmentList<G3> CompensationInformation { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<V1> VesselIdentification { get; }
        
        Segment<M0> LetterOfCreditReference { get; }
        
        SegmentList<M1> Insurance { get; }
        
        Segment<C2> BankId { get; }
        
        Segment<C3> CurrencyIdentifier { get; }

        SegmentList<Y2> ContainerDetails { get; }
        
        LayoutList<LoopN1_310> LoopN1 { get; }
        
        SegmentList<G61> Contact { get; }
        
        LayoutList<LoopR4_310> LoopR4 { get; }
        
        SegmentList<R2A> RouteInformationWithPreference { get; }
        
        SegmentList<R2> RouteInformation { get; }
        
        SegmentList<K1> Remarks1 { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        LayoutList<LoopC8_310> LoopC8 { get; }
        
        LayoutList<LoopLX_310> LoopLX { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        LayoutList<LoopL1_310> LoopL1 { get; }
        
        SegmentList<V9> EventDetail { get; }
        
        Segment<C8> CertificationsAndClauses { get; }
        
        SegmentList<K1> Remarks2 { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}