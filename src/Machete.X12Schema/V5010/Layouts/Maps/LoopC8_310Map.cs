namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopC8_310Map :
        X12LayoutMap<LoopC8_310, X12Entity>
    {
        public LoopC8_310Map()
        {
            Id = "Loop_C8_310";
            Name = "Loop C8";
            
            Segment(x => x.CertificationsAndClauses, 0);
            Segment(x => x.CertificationsClauses, 1);
        }
    }
}