namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT8 :
        X12Segment
    {
        Value<string> WeightQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<int> LadingQuantity1 { get; }
        
        Value<int> LadingQuantity2 { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<decimal> Volume { get; }
    }
}