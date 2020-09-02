namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopC8_310 :
        X12Layout
    {
        Segment<C8> CertificationsAndClauses { get; }
        
        SegmentList<C8C> CertificationsClauses { get; }
    }
}