namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0300_210 :
        X12Layout
    {
        Segment<S5> StopOffDetails { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<H3> SpecialHandlingInstructions { get; }
        
        LayoutList<Loop0305_210> Loop0305 { get; }
        
        LayoutList<Loop0310_210> Loop0310 { get; }
    }
}