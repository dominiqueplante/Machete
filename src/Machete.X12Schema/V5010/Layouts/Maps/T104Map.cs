namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T104Map :
        X12LayoutMap<T104, X12Entity>
    {
        public T104Map()
        {
            Id = "T104";
            Name = "104 Air Shipment Information";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.PartyIdentification, 2);
            Segment(x => x.AdditionalNameInformation, 3);
            Segment(x => x.PartyLocation, 4);
            Segment(x => x.GeographicLocation, 5);
            Segment(x => x.ExtendedReferenceInformation, 6);
            Segment(x => x.AdministrativeCommunicationsContact, 7);
            Segment(x => x.Pickup, 8);
            Segment(x => x.StatementIdentification, 9);
            Segment(x => x.OriginStation, 10);
            Layout(x => x.LoopFOB, 11);
            Segment(x => x.TotalWeightAndCharges, 12);
            Segment(x => x.NotesOrSpecialInstruction, 13);
            Segment(x => x.TransactionSetTrailer, 14);
            Segment(x => x.FunctionalGroupTrailer, 18);
        }
    }
}