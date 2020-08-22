namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T204 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B2> BeginningShipmentInformationTransaction { get; }
        
        Segment<B2A> SetPurpose { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<G62> DateOrTime { get; }
        
        Segment<MS3> InterlineInformation { get; }
        
        LayoutList<Loop0050_204> Loop0050 { get; }
        
        Segment<PLD> PalletShipmentInformation { get; }
        
        SegmentList<LH6> HazardousCertification { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        LayoutList<Loop0100_204> Loop0100 { get; }
        
        LayoutList<Loop0200_204> Loop0200 { get; }
        
        LayoutList<Loop0300_204> Loop0300 { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        Layout<Loop1000_204> Loop1000 { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}