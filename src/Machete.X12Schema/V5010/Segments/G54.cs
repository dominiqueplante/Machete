namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G54 :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> UniversalProductCodeCaseCode { get; }
        
        Value<string> ProductOrServiceIdQualifier { get; }
        
        Value<string> ProductOrServiceId { get; }
        
        Value<string> FreeformDescription { get; }
    }
}