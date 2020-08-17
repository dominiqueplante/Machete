namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T858Map :
        X12LayoutMap<T858, X12Entity>
    {
        public T858Map()
        {
            Id = "T858";
            Name = "858 Shipment Information";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningDataCorrectionOrChange, 2);
            Segment(x => x.GeneralShipmentInformation, 3);
            Segment(x => x.RailShipmentInformation, 4);
            Segment(x => x.Release, 5);
            Segment(x => x.ExtendedReferenceInformation, 5);
            Segment(x => x.CargoManifest, 6);
            Segment(x => x.Authentication, 7);
            Segment(x => x.CargoBookingPriority, 8);
            Segment(x => x.CurrencyIdentifier, 9);
            Segment(x => x.TermsOfSale, 10);
            Segment(x => x.DateOrTime, 11);
            Segment(x => x.AdministrativeCommunicationsContact, 12);
            Segment(x => x.CrossReferenceEquipment, 13);
            Segment(x => x.OriginStation, 14);
            Segment(x => x.DestinationStation, 15);
            Segment(x => x.RouteInformationAir, 16);
            Segment(x => x.RouteInformation, 17);
            Segment(x => x.RouteInformationMotor, 18);
            Segment(x => x.PortOrTerminal, 19);
            Segment(x => x.Measurements, 20);
            Segment(x => x.SpecialHandlingInstructions, 21);
            Segment(x => x.ProtectiveServicesInstructions, 22);
            Segment(x => x.SpecialServices, 23);
            Segment(x => x.CargoLocationReference, 24);
            Segment(x => x.VesselIdentification, 25);
            Layout(x => x.LoopE1, 26);
            Segment(x => x.Insurance, 27);
            Segment(x => x.SalesOrDeliveryTerms, 28);
            Segment(x => x.TariffReference, 29);
            Segment(x => x.NoteOrSpecialInstruction, 30);
            Segment(x => x.ProFormaB13Information, 31);
            Layout(x => x.LoopN7, 32);
            Layout(x => x.LoopN1, 33);
            Layout(x => x.LoopS5, 34);
            Layout(x => x.LoopFA1, 35);
            Layout(x => x.LoopHL, 36);
            Segment(x => x.TotalWeightAndCharges, 37);
            Segment(x => x.TransactionSetTrailer, 38);
            Segment(x => x.FunctionalGroupTrailer, 39);
        }
    }
}