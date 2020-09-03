namespace Machete.X12Schema.V5010
{
    using X12;


    public interface S9 :
        X12Segment
    {
        Value<int> StopSequenceNumber { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> StopReasonCode { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> LocationIdentifier { get; }
    }
}