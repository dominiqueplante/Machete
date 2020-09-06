namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface ED :
        X12Segment
    {
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber1 { get; }
        
        Value<string> LoadOrEmptyStatusCode { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> LadingDescription { get; }
        
        Value<int> WaybillNumber { get; }
        
        Value<string> EquipmentNumber2 { get; }
        
        Value<DateTime> Date { get; }
    }
}