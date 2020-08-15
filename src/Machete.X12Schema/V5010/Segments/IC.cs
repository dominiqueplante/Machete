namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IC :
        X12Segment
    {
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<int> TareWeight { get; }
        
        Value<string> TareQualifierCode { get; }
        
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<int> EquipmentLength { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<string> ChassisType { get; }
        
        Value<int> EquipmentNumberCheckDigit { get; }
    }
}