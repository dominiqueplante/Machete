namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LAD :
        X12Segment
    {
        Value<string> PackagingFormCode { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<string> WeightUnitCode1 { get; }
        
        Value<decimal> UnitWeight { get; }
        
        Value<string> WeightUnitCode2 { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
        
        Value<int> LadingDescription { get; }
        
        Value<int> LadingValue { get; }
    }
}