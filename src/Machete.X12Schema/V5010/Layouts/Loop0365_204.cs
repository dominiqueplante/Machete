namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0365_204 :
        X12Layout
    {
        Segment<G61> Contact { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<LH6> HazardousCertification { get; }
        
        LayoutList<Loop0370_204> Loop0370 { get; }
    }
}