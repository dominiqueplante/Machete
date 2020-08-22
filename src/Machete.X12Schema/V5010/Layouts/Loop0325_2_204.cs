namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0325_2_204 :
        X12Layout
    {
        SegmentList<G61> Contact { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<LH6> HazardousCertification { get; }
        
        LayoutList<Loop0330_204> Loop0330 { get; }
    }
}