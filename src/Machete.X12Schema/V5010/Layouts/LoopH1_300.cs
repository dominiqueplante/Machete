namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopH1_300 :
        X12Layout
    {
        Segment<H1> HazardousMaterial { get; }
        
        SegmentList<H2> AdditionalHazardousMaterialDescription { get; }
    }
}