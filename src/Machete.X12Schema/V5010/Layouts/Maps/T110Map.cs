namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T110Map :
        X12LayoutMap<T110, X12Entity>
    {
        public T110Map()
        {
            Id = "T110";
            Name = "110 Air Freight Details and Invoice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForCarrierInvoice, 2);
            Segment(x => x.InvoiceType, 3);
            Segment(x => x.BankId, 4);
            Segment(x => x.CurrencyIdentifier, 5);
            Segment(x => x.TermsOfSale, 6);
            Layout(x => x.LoopN1, 7);
            Layout(x => x.LoopLX, 8);
            Segment(x => x.TotalWeightAndCharges, 9);
            Segment(x => x.AncillaryCharges, 10);
            Segment(x => x.NotesOrSpecialInstruction, 11);
            Segment(x => x.TransactionSetTrailer, 12);
            Segment(x => x.FunctionalGroupTrailer, 13);
        }
    }
}