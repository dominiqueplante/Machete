namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface V9 :
        X12Segment
    {
        Value<string> EventCode { get; }
        
        Value<string> Event { get; }

        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> StatusReasonCode { get; }
        
        Value<string> StandardPointLocationCode1 { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<string> TrainDelayReasonCode { get; }
        
        Value<string> FreeformInformation { get; }
        
        Value<string> TimeCode { get; }
        
        Value<decimal> Quantity2 { get; }
        
        Value<string> StandardPointLocationCode2 { get; }
        
        Value<int> TotalEquipment1 { get; }
        
        Value<int> TotalEquipment2 { get; }
        
        Value<int> TotalEquipment3 { get; }
        
        Value<decimal> Weight { get; }
        
        Value<decimal> Length { get; }
    }
}