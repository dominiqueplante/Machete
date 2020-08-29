namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopNM1_823Map :
        X12LayoutMap<LoopNM1_823, X12Entity>
    {
        public LoopNM1_823Map()
        {
            Id = "Loop_NM1_823";
            Name = "Loop NM1";
            
            Segment(x => x.IndividualOrOrganizationalName, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.MaintenanceType, 2);
            Layout(x => x.LoopAIN, 3);
            Layout(x => x.LoopPEN, 4);
        }
    }
}