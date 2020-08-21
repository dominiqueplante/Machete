namespace Machete.X12Schema.V5010
{
    using X12;


    public interface MS2 :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> EquipmentDescriptionCode { get; }
        
        Value<string> EquipmentNumberCheckDigit { get; }
    }
}