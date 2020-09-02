namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L12 :
        X12Segment
    {
        Value<string> LadingDescriptionQualifier { get; }
        
        Value<string> Description { get; }
    }
}