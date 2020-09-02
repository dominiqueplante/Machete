namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface B4 :
        X12Segment
    {
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> InquiryRequestNumber { get; }
        
        Value<string> ShipmentStatusCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> StatusLocation { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> EquipmentStatusCode { get; }
        
        Value<string> EquipmentType { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> EquipmentNumberCheckDigit { get; }
    }
}