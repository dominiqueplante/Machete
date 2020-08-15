namespace Machete.X12Schema.V5010
{
    using X12;


    public interface N5 :
        X12Segment
    {
        Value<int> EquipmentLength { get; }
        
        Value<int> WeightCapacity { get; }
        
        Value<int> CubicCapacity { get; }
        
        Value<string> CarTypeCode { get; }
        
        Value<string> MetricQualifier { get; }
        
        Value<decimal> Height { get; }
        
        Value<decimal> LadingPercentage { get; }
        
        Value<string> LadingPercentQualifier { get; }
        
        Value<string> EquipmentDescriptionCode { get; }
    }
}