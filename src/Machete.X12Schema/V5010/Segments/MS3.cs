namespace Machete.X12Schema.V5010
{
    using X12;


    public interface MS3 :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> RoutingSequenceCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> StateOrProvinceCode { get; }
    }
}