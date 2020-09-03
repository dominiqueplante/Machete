namespace Machete.X12Schema.V5010
{
    using X12;


    public interface N10 :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<string> FreeformDescription { get; }
        
        Value<string> MarksAndNumbers { get; }
        
        Value<string> CommodityCodeQualifier { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> CustomsShipmentValue { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> ManifestUnitCode { get; }
        
        Value<string> CountryCode1 { get; }

        Value<string> CountryCode2 { get; }
        
        Value<string> CurrencyCode { get; }
    }
}