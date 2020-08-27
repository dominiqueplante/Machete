namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G93 :
        X12Segment
    {
        Value<string> PriceBracketIdentifier { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> FreeformDescription { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> PriceIdentifierCode { get; }
        
        Value<string> ActionCode { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}