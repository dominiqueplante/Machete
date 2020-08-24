namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1200_214 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        Segment<L11> BusinessInstructionsAndReferenceNumber { get; }
    }
}