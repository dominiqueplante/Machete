namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G40 :
        X12Segment
    {
        Value<string> PriceBracketIdentifier { get; }
        
        Value<decimal> ItemListCostNew { get; }
        
        Value<decimal> ItemListCostOld { get; }
        
        Value<string> FreeformDescription { get; }
        
        Value<decimal> PriceNewSuggestedRetail { get; }
        
        Value<decimal> PriceOldSuggestedRetail { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> PriceIdentifierCode { get; }
        
        Value<int> Number { get; }
    }
}