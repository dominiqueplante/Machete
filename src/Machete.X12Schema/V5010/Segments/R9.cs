namespace Machete.X12Schema.V5010
{
    using X12;


    public interface R9 :
        X12Segment
    {
        Value<string> RouteCode1 { get; }
        
        Value<string> AgentOrShipperRoutingCode { get; }
        
        Value<string> IntermodalServiceCode { get; }
        
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<string> ActionCode { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<string> YesNoConditionOrResponseCode1 { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
        
        Value<string> RouteCode2 { get; }
    }
}