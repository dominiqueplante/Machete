namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LFG :
        X12Segment
    {
        Value<string> Description { get; }
        
        Value<string> HazardousClassification { get; }
        
        Value<string> UnitedNationsOrNorthAmericanIdentificationCode { get; }
        
        Value<string> HazardousPlacardNotation { get; }
        
        Value<string> PackingGroupCode { get; }
        
        Value<string> HazardousMaterialRegulationsExceptionCode { get; }
    }
}