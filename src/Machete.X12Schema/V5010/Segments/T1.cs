namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface T1 :
        X12Segment
    {
        Value<int> AssignedNumber { get; }
        
        Value<int> WaybillNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> TransitRegistrationNumber { get; }
        
        Value<string> TransitLevelCode { get; }
        
        Value<string> ReferenceIdentifierQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
    }
}