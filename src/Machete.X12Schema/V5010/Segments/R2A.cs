namespace Machete.X12Schema.V5010
{
    using X12;


    public interface R2A :
        X12Segment
    {
        Value<string> RoutingSequenceCode { get; }
        
        Value<string> Preference { get; }
        
        Value<string> TransportationMethodCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> TypeOfServiceCode { get; }
        
        Value<string> RouteCode { get; }
        
        Value<string> RouteDescription { get; }
        
        Value<string> EntityIdentifierCode { get; }
    }
}