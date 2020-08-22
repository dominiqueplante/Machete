namespace Machete.X12Schema.V5010
{
    using X12;


    public interface H2 :
        X12Segment
    {
        Value<string> HazardousMaterialDescription { get; }
        
        Value<string> HazardousMaterialClassification { get; }
    }
}