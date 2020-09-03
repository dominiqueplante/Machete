namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T410Map :
        X12LayoutMap<T410, X12Entity>
    {
        public T410Map()
        {
            Id = "T410";
            Name = "410 Rail Carrier Freight Details and Invoice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForRailCarrierInvoice, 2);
            Segment(x => x.AlternateAmountDue, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.CargoManifest, 5);
            Segment(x => x.NoteOrSpecialInstruction, 6);
            Layout(x => x.LoopN7, 7);
            Segment(x => x.WaybillReference, 8);
            Segment(x => x.OriginStation, 9);
            Segment(x => x.DestinationStation, 10);
            Layout(x => x.LoopN1, 11);
            Layout(x => x.LoopS1, 12);
            Segment(x => x.RouteInformation, 13);
            Segment(x => x.RouteCodeIdentification, 14);
            Segment(x => x.ProtectiveServicesInstructions, 15);
            Layout(x => x.LoopLX, 16);
            Layout(x => x.LoopT1, 17);
            Segment(x => x.TotalWeightAndCharges, 18);
            Segment(x => x.CustomsInformation, 19);
            Segment(x => x.TransactionSetTrailer, 34);
            Segment(x => x.FunctionalGroupTrailer, 35);
        }
    }
}