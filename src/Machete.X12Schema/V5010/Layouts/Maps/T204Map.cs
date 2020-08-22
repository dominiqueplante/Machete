namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T204Map :
        X12LayoutMap<T204, X12Entity>
    {
        public T204Map()
        {
            Id = "T204";
            Name = "204 Motor Carrier Load Tender";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningShipmentInformationTransaction, 2);
            Segment(x => x.SetPurpose, 3);
            Segment(x => x.CurrencyIdentifier, 4);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 5);
            Segment(x => x.DateOrTime, 6);
            Segment(x => x.InterlineInformation, 7);
            Layout(x => x.Loop0050, 8);
            Segment(x => x.PalletShipmentInformation, 9);
            Segment(x => x.HazardousCertification, 10);
            Segment(x => x.NotesOrSpecialInstruction, 11);
            Layout(x => x.Loop0100, 12);
            Layout(x => x.Loop0200, 13);
            Layout(x => x.Loop0300, 14);
            Segment(x => x.TotalWeightAndCharges, 15);
            Layout(x => x.Loop1000, 16);
            Segment(x => x.TransactionSetTrailer, 17);
            Segment(x => x.FunctionalGroupTrailer, 18);
        }
    }
}