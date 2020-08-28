namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_830 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<NM1> IndividualOrOrganizationalName { get; }
    }
}