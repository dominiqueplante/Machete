namespace Machete.X12Schema.V5010
{
    using X12;


    public interface N7 :
        X12Segment
    {
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<int> TareWeight { get; }
        
        Value<int> WeightAllowance { get; }
        
        Value<int> Dunnage { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<string> OwnershipCode { get; }
        
        Value<string> EquipmentDescriptionCode { get; }
        
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<string> TemperatureControl { get; }
        
        Value<string> Position { get; }
        
        Value<int> EquipmentLength { get; }
        
        Value<string> TareQualifierCode { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<int> EquipmentNumberCheckDigit { get; }
        
        Value<string> TypeOfServiceCode { get; }
        
        Value<decimal> Height { get; }
        
        Value<decimal> Width { get; }
        
        Value<string> EquipmentType { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<string> CarTypeCode { get; }
    }
}