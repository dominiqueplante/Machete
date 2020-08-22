namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0350_204 :
        X12Layout
    {
        Segment<OID> OrderInformationDetail { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<LAD> LadingDetail { get; }
        
        LayoutList<Loop0360_204> Loop0360 { get; }
    }
}