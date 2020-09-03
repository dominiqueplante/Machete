namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T3 :
        X12Segment
    {
        Value<int> AssignedNumber { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> RoutingSequenceCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
    }
}