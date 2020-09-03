namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_1_417 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }

        SegmentList<N3> PartyLocation { get; }

        Segment<N4> GeographicLocation { get; }
        
        Segment<H3> SpecialHandlingInstructions { get; }
    }
}