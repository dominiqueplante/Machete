namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PKL :
        X12Segment
    {
        Value<string> ProductOrServiceIdQualifier { get; }
        
        Value<string> ProductOrServiceId { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<decimal> Height { get; }
        
        Value<decimal> Width { get; }
        
        Value<decimal> ItemDepth { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> GrossWeightPerPack { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> GrossVolumePerPack { get; }
        
        Value<string> UnitOrBasisForMeasurementCode4 { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}