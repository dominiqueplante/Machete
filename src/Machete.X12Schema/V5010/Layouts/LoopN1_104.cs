namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_104 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        Segment<N2> AdditionalNameInformation { get; }
        
        Segment<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        Segment<PER> AdministrativeCommunicationsContact { get; }
    }
}