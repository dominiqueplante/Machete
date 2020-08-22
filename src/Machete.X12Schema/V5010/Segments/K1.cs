namespace Machete.X12Schema.V5010
{
    using X12;


    public interface K1 :
        X12Segment
    {
        Value<string> FreeformInformation1 { get; }
        
        Value<string> FreeformInformation2 { get; }
    }
}