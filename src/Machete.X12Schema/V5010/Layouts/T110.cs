namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T110 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B3> BeginningSegmentForCarrierInvoice { get; }
        
        Segment<B3A> InvoiceType { get; }
        
        Segment<C2> BankId { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
        
        Segment<ITD> TermsOfSale { get; }
        
        LayoutList<LoopN1_110> LoopN1 { get; }
        
        LayoutList<LoopLX_110> LoopLX { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        SegmentList<ACS> AncillaryCharges { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}