namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SUP :
        X12Segment
    {
        Value<string> SupplementaryInformationQualifier { get; }
        
        Value<string> CertificationOrClauseCode { get; }
        
        Value<string> FreeformMessage { get; }
        
        Value<string> PrintOptionCode { get; }
    }
}