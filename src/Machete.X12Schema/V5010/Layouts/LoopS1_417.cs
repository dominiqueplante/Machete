namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopS1_417 :
        X12Layout
    {
        Segment<S1> StopOffName { get; }
        
        Segment<S2> StopOffAddress { get; }
        
        Segment<S9> StopOffStation { get; }
        
        Segment<N1> PartyIdentification { get; }

        SegmentList<N2> AdditionalNameInformation { get; }

        SegmentList<N3> PartyLocation { get; }

        Segment<N4> GeographicLocation { get; }

        SegmentList<PER> AdministrativeCommunicationsContact { get; }
    }
}