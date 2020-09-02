namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T304Map :
        X12LayoutMap<T304, X12Entity>
    {
        public T304Map()
        {
            Id = "T304";
            Name = "304 Shipping Instructions";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningShipmentInformationTransaction, 2);
            Segment(x => x.SetPurpose, 3);
            Segment(x => x.Authentication, 4);
            Segment(x => x.BeginningSegmentForBookingOrPickupDelivery, 5);
            Segment(x => x.ShipmentTypeInformation, 6);
            Segment(x => x.BeyondRouting, 7);
            Segment(x => x.CompensationInformation, 8);
            Segment(x => x.ExtendedReferenceInformation, 9);
            Segment(x => x.YesOrNoQuestion, 10);
            Segment(x => x.VesselIdentification, 11);
            Segment(x => x.SpaceConfirmation, 12);
            Segment(x => x.LetterOfCreditReference, 13);
            Segment(x => x.Currency, 14);
            Layout(x => x.LoopM1, 15);
            Segment(x => x.SalesOrDeliveryTerms, 16);
            Segment(x => x.BankId, 17);
            Segment(x => x.TermsOfSale, 18);
            Segment(x => x.DateOrTimeReference, 19);
            Segment(x => x.TermsOfSale, 20);
            Layout(x => x.LoopN1, 21);
            Layout(x => x.LoopR4, 22);
            Segment(x => x.RouteInformationWithPreference, 23);
            Segment(x => x.RouteInformation, 24);
            Segment(x => x.Remarks, 25);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 26);
            Segment(x => x.SpecialHandlingInstructions, 27);
            Segment(x => x.DescriptionMarksAndNumbers, 28);
            Segment(x => x.ExportLicense, 29);
            Segment(x => x.ImportLicense, 30);
            Layout(x => x.LoopC8, 31);
            Layout(x => x.LoopLX, 32);
            Layout(x => x.LoopL3, 33);
            Segment(x => x.TransactionSetTrailer, 34);
            Segment(x => x.FunctionalGroupTrailer, 35);
        }
    }
}