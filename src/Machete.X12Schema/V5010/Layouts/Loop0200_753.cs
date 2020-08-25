namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0200_753 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        Segment<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<G62> DateOrTime { get; }
        
        Segment<G61> Contact { get; }
        
        LayoutList<Loop0210_753> Loop0210 { get; }
    }
}