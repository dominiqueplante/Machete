namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopC8_304 :
        X12Layout
    {
        Segment<C8> CertificationsAndClauses { get; }
        
        SegmentList<C8C> CertificationsClauses { get; }
        
        SegmentList<SUP> SupplementaryInformation { get; }
    }
}