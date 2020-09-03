namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T417Map :
        X12LayoutMap<T417, X12Entity>
    {
        public T417Map()
        {
            Id = "T417";
            Name = "417 Rail Carrier Waybill Interchange";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningDataCorrectionOrChange, 2);
            Segment(x => x.GeneralShipmentInformation, 3);
            Segment(x => x.RailShipmentInformation, 4);
            Segment(x => x.ExtendedReferenceInformation, 5);
            Segment(x => x.CargoManifest, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Layout(x => x.LoopN7, 8);
            Segment(x => x.WaybillReference, 9);
            Segment(x => x.AdditionalReferenceInformation, 10);
            Segment(x => x.EventDetail, 11);
            Segment(x => x.OriginStation, 12);
            Segment(x => x.DestinationStation, 13);
            Layout(x => x.LoopN1, 14);
            Layout(x => x.LoopS1, 15);
            Segment(x => x.RouteInformation, 16);
            Segment(x => x.RouteCodeIdentification, 17);
            Layout(x => x.LoopE1, 18);
            Segment(x => x.SpecialHandlingInstructions, 19);
            Segment(x => x.ProtectiveServicesInstructions, 20);
            Layout(x => x.LoopLX, 21);
            Layout(x => x.LoopT1, 22);
            Segment(x => x.LoopHeader, 23);
            Layout(x => x.LoopLH1, 24);
            Segment(x => x.LoopTrailer, 25);
            Segment(x => x.AdministrativeCommunicationsContact, 26);
            Segment(x => x.HazardousClassificationInformation, 27);
            Segment(x => x.HazardousMaterialIdentifyingReferenceNumbers, 28);
            Segment(x => x.ProFormaB13Information, 29);
            Segment(x => x.CustomsInformation, 30);
            Segment(x => x.TransactionSetTrailer, 31);
            Segment(x => x.FunctionalGroupTrailer, 32);
        }
    }
}