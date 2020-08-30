namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface P1 :
        X12Segment
    {
        Value<string> PickupOrDeliveryCode { get; }
        
        Value<DateTime> PickupDate { get; }
        
        Value<int> DateOrTimeQualifier { get; }
        
        Value<TimeSpan> PickupTime { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<int> NumberOfShipments { get; }
    }
}