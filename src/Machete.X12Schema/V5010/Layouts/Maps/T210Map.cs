namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T210Map :
        X12LayoutMap<T210, X12Entity>
    {
        public T210Map()
        {
            Id = "T210";
            Name = "204 Motor Carrier Load Tender";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningCarrierInvoice, 2);
            Segment(x => x.BankId, 3);
            Segment(x => x.CurrencyIdentifier, 4);
            Segment(x => x.TermsOfSale, 5);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 6);
            Segment(x => x.DateOrTime, 7);
            Segment(x => x.RouteInformationMotor, 8);
            Segment(x => x.SpecialHandlingInstructions, 9);
            Segment(x => x.Remarks, 10);
            Layout(x => x.Loop0100, 11);
            Layout(x => x.Loop0200, 12);
            Layout(x => x.Loop0250, 13);
            Layout(x => x.Loop0300, 14);
            Layout(x => x.Loop0400, 15);
            Segment(x => x.TotalWeightAndCharges, 16);
            Segment(x => x.TransactionSetTrailer, 17);
            Segment(x => x.FunctionalGroupTrailer, 18);
        }
    }
}