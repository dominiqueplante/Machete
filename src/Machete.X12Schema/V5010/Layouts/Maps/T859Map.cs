namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T859Map :
        X12LayoutMap<T859, X12Entity>
    {
        public T859Map()
        {
            Id = "T859";
            Name = "859 Freight Invoice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForCarrierInvoice, 2);
            Segment(x => x.InvoiceType, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.CargoManifest, 5);
            Segment(x => x.Authentication, 6);
            Segment(x => x.CargoBookingPriority, 7);
            Segment(x => x.CurrencyIdentifier, 8);
            Segment(x => x.TermsOfSale, 9);
            Segment(x => x.DateOrTime, 10);
            Segment(x => x.AdministrativeCommunicationsContact, 11);
            Segment(x => x.CrossReferenceEquipment, 12);
            Segment(x => x.OriginStation, 13);
            Segment(x => x.DestinationStation, 14);
            Segment(x => x.RouteInformationAir, 16);
            Segment(x => x.RouteInformation, 17);
            Segment(x => x.SpecialHandlingInstructions, 18);
            Segment(x => x.ProtectiveServicesInstructions, 19);
            Segment(x => x.SpecialServices, 20);
            Segment(x => x.Insurance, 21);
            Segment(x => x.SalesOrDeliveryTerms, 22);
            Segment(x => x.TariffReference, 23);
            Segment(x => x.NoteOrSpecialInstruction, 24);
            Segment(x => x.ProFormaB13Information, 25);
            Segment(x => x.Pickup, 26);
            Segment(x => x.AllowanceChargeOrService, 27);
            Segment(x => x.WaybillReference, 28);
            Segment(x => x.RouteCodeIdentification, 29);
            Layout(x => x.LoopH1, 30);
            Layout(x => x.LoopN7, 31);
            Layout(x => x.LoopN1, 32);
            Layout(x => x.LoopS5, 33);
            Layout(x => x.LoopLX, 34);
            Segment(x => x.TotalWeightAndCharges, 35);
            Segment(x => x.TransactionSetTrailer, 36);
            Segment(x => x.FunctionalGroupTrailer, 37);
        }
    }
}