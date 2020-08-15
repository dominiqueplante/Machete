namespace Machete.X12Schema.V5010
{
    using X12;


    public interface NA :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> CrossReferenceTypeCode { get; }
        
        Value<string> Position { get; }
        
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<int> EquipmentLength { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<string> ChassisType { get; }
         
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<int> EquipmentNumberCheckDigit { get; }
    }
}