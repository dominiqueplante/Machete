namespace Machete.X12Schema.V5010
{
    using X12;


    public interface V2 :
        X12Segment
    {
        Value<string> LocationIdentifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<decimal> Weight1 { get; }
        
        Value<string> WeightUnitCode1 { get; }
        
        Value<decimal> Weight2 { get; }
        
        Value<string> WeightUnitCode2 { get; }
        
        Value<decimal> Weight3 { get; }
        
        Value<string> WeightUnitCode3 { get; }
        
        Value<decimal> Weight4 { get; }
        
        Value<string> WeightUnitCode4 { get; }
        
        Value<decimal> Weight5 { get; }
        
        Value<string> WeightUnitCode5 { get; }
        
        Value<string> Name { get; }
        
        Value<decimal> Length { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<decimal> Quantity2 { get; }
    }
}