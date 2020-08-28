namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RED :
        X12Segment
    {
        Value<string> Description { get; }
        
        Value<string> RelatedDataIdentificationCode { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> SourceSubqualifier { get; }
        
        Value<string> CodeListQualifierCode { get; }
        
        Value<string> IndustryCode { get; }
    }
}