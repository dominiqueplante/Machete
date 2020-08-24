namespace Machete.X12Schema.V5010
{
    using X12;


    public interface K2 :
        X12Segment
    {
        Value<string> Description { get; }
    }
}