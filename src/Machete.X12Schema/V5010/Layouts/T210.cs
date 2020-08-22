namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T210 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B3> BeginningCarrierInvoice { get; }
        
        Segment<C2> BankId { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
        
        Segment<ITD> TermsOfSale { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<G62> DateOrTime { get; }
        
        SegmentList<R3> RouteInformationMotor { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        SegmentList<K1> Remarks { get; }
        
        LayoutList<Loop0100_204> Loop0100 { get; }
        
        LayoutList<Loop0200_204> Loop0200 { get; }
        
        LayoutList<Loop0250_210> Loop0250 { get; }
        
        LayoutList<Loop0300_210> Loop0300 { get; }
        
        LayoutList<Loop0400_210> Loop0400 { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}