namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopNM1_823 :
        X12Layout
    {
        Segment<REF> IndividualOrOrganizationalName { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<G53> MaintenanceType { get;  }

        LayoutList<LoopAIN_823> LoopAIN { get; }

        LayoutList<LoopPEN_823> LoopPEN { get; }
    }
}