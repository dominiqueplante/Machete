namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface N8A :
        X12Segment
    {
        Value<string> WaybillCrossReferenceCode { get; }
        
        Value<string> WaybillNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> FreightStationAccountingCode { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
    }
}