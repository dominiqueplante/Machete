namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopC8_304Map :
        X12LayoutMap<LoopC8_304, X12Entity>
    {
        public LoopC8_304Map()
        {
            Id = "Loop_C8_304";
            Name = "Loop C8";
            
            Segment(x => x.CertificationsAndClauses, 0);
            Segment(x => x.CertificationsClauses, 1);
            Segment(x => x.SupplementaryInformation, 2);
        }
    }
}