namespace Machete.X12Schema.V5010
{
    using X12;


    public interface S5 :
        X12Segment
    {
        Value<int> StopSequenceNumber { get; }
        
        Value<string> StopReasonCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<string> Description { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> AccomplishCode { get; }
    }
}