namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface Y4 :
        X12Segment
    {
        Value<string> BookingNumber1 { get; }
        
        Value<string> BookingNumber2 { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<int> NumberOfContainers { get; }
        
        Value<string> EquipmentType { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> TypeOfServiceCode { get; }
    }
}