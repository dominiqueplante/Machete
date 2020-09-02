namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C8C :
        X12Segment
    {
        Value<string> CertificationOrClauseText1 { get; }
        
        Value<string> CertificationOrClauseText2 { get; }
        
        Value<string> CertificationOrClauseText3 { get; }
    }
}