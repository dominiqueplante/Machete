namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface Y1 :
        X12Segment
    {
        Value<DateTime> SailingOrFlightDateEstimated { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> TransportationMethodCode { get; }
        
        Value<string> EntityIdentifierCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> TariffServiceCode { get; }
        
        Value<string> DateOrTimeQualifier { get; }
    }
}