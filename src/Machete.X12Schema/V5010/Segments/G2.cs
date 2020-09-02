namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G2 :
        X12Segment
    {
        Value<string> SpecialIndicatorCode { get; }
        
        Value<string> Description { get; }
    }
}