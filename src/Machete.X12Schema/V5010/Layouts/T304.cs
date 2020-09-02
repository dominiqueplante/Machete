namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T304 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B2> BeginningShipmentInformationTransaction { get; }
        
        Segment<B2A> SetPurpose { get; }
        
        SegmentList<Y6> Authentication { get; }

        Segment<B1> BeginningSegmentForBookingOrPickupDelivery { get; }
        
        SegmentList<G1> ShipmentTypeInformation { get; }
        
        SegmentList<G2> BeyondRouting { get; }
        
        SegmentList<G3> CompensationInformation { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<YNQ> YesOrNoQuestion { get; }
        
        SegmentList<V1> VesselIdentification { get; }
        
        Segment<Y3> SpaceConfirmation { get; }
        
        Segment<M0> LetterOfCreditReference { get; }
        
        Segment<CUR> Currency { get; }
        
        LayoutList<LoopM1_304> LoopM1 { get; }
        
        Segment<M2> SalesOrDeliveryTerms { get; }
        
        Segment<C2> BankId { get; }
        
        Segment<ITD> TermsOfSale { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopN1_304> LoopN1 { get; }
        
        LayoutList<LoopR4_304> LoopR4 { get; }
        
        SegmentList<R2A> RouteInformationWithPreference { get; }
        
        SegmentList<R2> RouteInformation { get; }
        
        SegmentList<K1> Remarks { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        SegmentList<X1> ExportLicense { get; }
        
        SegmentList<X2> ImportLicense { get; }
        
        LayoutList<LoopC8_304> LoopC8 { get; }
        
        LayoutList<LoopLX_304> LoopLX { get; }
        
        LayoutList<LoopL3_304> LoopL3 { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}