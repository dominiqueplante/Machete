namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_410 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }

        Segment<N2> AdditionalNameInformation { get; }

        SegmentList<N3> PartyLocation { get; }

        Segment<N4> GeographicLocation { get; }

        SegmentList<PER> AdministrativeCommunicationsContact { get; }

        SegmentList<BL> BillingInformation { get; }
    }
}