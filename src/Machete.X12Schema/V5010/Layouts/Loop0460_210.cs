namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0460_210 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        Segment<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        LayoutList<Loop0463_210> Loop0463 { get; }
        
        LayoutList<Loop0465_210> Loop0465 { get; }
    }
}