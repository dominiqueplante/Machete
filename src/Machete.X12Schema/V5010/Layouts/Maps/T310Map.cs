namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T310Map :
        X12LayoutMap<T310, X12Entity>
    {
        public T310Map()
        {
            Id = "T310";
            Name = "310 Freight Receipt and Invoice (Ocean)";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForCarrierInvoice, 2);
            Segment(x => x.SetPurpose, 3);
            Segment(x => x.Authentication, 4);
            Segment(x => x.CompensationInformation, 5);
            Segment(x => x.ExtendedReferenceInformation, 6);
            Segment(x => x.VesselIdentification, 7);
            Segment(x => x.LetterOfCreditReference, 8);
            Segment(x => x.Insurance, 9);
            Segment(x => x.BankId, 10);
            Segment(x => x.CurrencyIdentifier, 11);
            Segment(x => x.ContainerDetails, 12);
            Layout(x => x.LoopN1, 13);
            Segment(x => x.Contact, 14);
            Layout(x => x.LoopR4, 15);
            Segment(x => x.RouteInformationWithPreference, 16);
            Segment(x => x.RouteInformation, 17);
            Segment(x => x.Remarks1, 18);
            Segment(x => x.SpecialHandlingInstructions, 19);
            Segment(x => x.DescriptionMarksAndNumbers, 20);
            Layout(x => x.LoopC8, 21);
            Layout(x => x.LoopLX, 22);
            Segment(x => x.TotalWeightAndCharges, 23);
            Segment(x => x.Paperwork, 24);
            Layout(x => x.LoopL1, 25);
            Segment(x => x.EventDetail, 26);
            Segment(x => x.CertificationsAndClauses, 27);
            Segment(x => x.Remarks2, 28);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 29);
            Segment(x => x.TransactionSetTrailer, 34);
            Segment(x => x.FunctionalGroupTrailer, 35);
        }
    }
}