namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface N8 :
        X12Segment
    {
        Value<int> WaybillNumber1 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<string> CrossReferenceTypeCode { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<int> WaybillNumber2 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> FreightStationAccountingCode { get; }
    }
}