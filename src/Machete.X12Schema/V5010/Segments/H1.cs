namespace Machete.X12Schema.V5010
{
    using X12;


    public interface H1 :
        X12Segment
    {
        Value<string> HazardousMaterialCode { get; }
        
        Value<string> HazardousMaterialClassCode { get; }
        
        Value<string> HazardousMaterialCodeQualifier { get; }
        
        Value<string> HazardousMaterialDescription { get; }
        
        Value<string> HazardousMaterialContact { get; }
        
        Value<string> HazardousMaterialsPage { get; }
        
        Value<int> FlashpointTemperature { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<string> PackingGroupCode { get; }
    }
}