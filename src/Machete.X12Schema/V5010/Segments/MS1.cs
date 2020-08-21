namespace Machete.X12Schema.V5010
{
    using X12;


    public interface MS1 :
        X12Segment
    {
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> LongitudeCode { get; }
        
        Value<string> LatitudeCode { get; }
        
        Value<string> DirectionIdentifierCode1 { get; }
        
        Value<string> DirectionIdentifierCode2 { get; }
        
        Value<string> PostalCode { get; }
    }
}