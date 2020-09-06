namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T311Map :
        X12LayoutMap<T311, X12Entity>
    {
        public T311Map()
        {
            Id = "T311";
            Name = "311 Canada Customs Information";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.SetPurpose, 2);
            Segment(x => x.Authentication, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.VesselIdentification, 5);
            Segment(x => x.VesselInformation, 6);
            Segment(x => x.VesselSchedule, 7);
            Segment(x => x.DateOrTimeReference, 8);
            Layout(x => x.LoopN1, 9);
            Segment(x => x.PortOrTerminal, 10);
            Segment(x => x.Remarks1, 11);
            Layout(x => x.LoopLX, 12);
            Segment(x => x.TotalWeightAndCharges, 13);
            Segment(x => x.Remarks2, 14);
            Segment(x => x.TransactionSetTrailer, 15);
            Segment(x => x.FunctionalGroupTrailer, 16);
        }
    }
}