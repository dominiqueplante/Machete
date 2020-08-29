namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G86 :
        X12Segment
    {
        Value<string> Signature { get; }
        
        Value<string> Name { get; }
    }
}