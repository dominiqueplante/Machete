namespace Machete.X12Schema.V5010
{
    using X12;


    public interface BL :
        X12Segment
    {
        Value<string> RebillReasonCode { get; }
        
        Value<string> FreightStationAccountingCode1 { get; }
        
        Value<string> FreightStationAccountingCode2 { get; }
        
        Value<string> StandardPointLocationCode1 { get; }
        
        Value<string> CityName1 { get; }
        
        Value<string> StateOrProvinceCode1 { get; }
        
        Value<string> CountryCode1 { get; }
        
        Value<string> StandardPointLocationCode2 { get; }
        
        Value<string> CityName2 { get; }
        
        Value<string> StateOrProvinceCode2 { get; }
        
        Value<string> CountryCode2 { get; }
        
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<string> StandardCarrierAlphaCode3 { get; }
        
        Value<string> StandardCarrierAlphaCode4 { get; }
        
        Value<string> StandardCarrierAlphaCode5 { get; }
        
        Value<string> StandardCarrierAlphaCode6 { get; }
    }
}