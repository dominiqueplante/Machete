namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT5 :
        X12Segment
    {
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> SpecialServicesCode { get; }
        
        Value<string> SpecialHandlingDescription { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<decimal> Temperature1 { get; }
        
        Value<decimal> Temperature2 { get; }
    }
}