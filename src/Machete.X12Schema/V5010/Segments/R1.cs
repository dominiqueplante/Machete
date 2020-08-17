namespace Machete.X12Schema.V5010
{
    using X12;


    public interface R1 :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<string> AirportCode1 { get; }
        
        Value<string> AirCarrierCode1 { get; }
        
        Value<string> AirportCode2 { get; }
        
        Value<string> AirCarrierCode2 { get; }
        
        Value<string> AirportCode3 { get; }
        
        Value<string> AirCarrierCode3 { get; }
        
        Value<string> AirportCode4 { get; }
        
        Value<string> AirCarrierCode4 { get; }
        
        Value<string> AirportCode5 { get; }
        
        Value<string> AirCarrierCode5 { get; }
        
        Value<string> AirportCode6 { get; }
    }
}