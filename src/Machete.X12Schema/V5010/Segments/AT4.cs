namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT4 :
        X12Segment
    {
        Value<string> LadingDescription { get; }
    }
}