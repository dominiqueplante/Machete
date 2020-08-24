namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT2 :
        X12Segment
    {
        Value<int> LadingQuantity1 { get; }
        
        Value<string> PackagingFormCode1 { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<int> LadingQuantity2 { get; }
        
        Value<string> PackagingFormCode2 { get; }
        
        Value<string> YesNoConditionOrResponseCode1 { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> FreightClassCode { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
        
        Value<decimal> LadingValue { get; }
    }
}