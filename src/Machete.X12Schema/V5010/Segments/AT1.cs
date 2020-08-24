namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT1 :
        X12Segment
    {
        Value<int> LadingLineItemNumber { get; }
    }
}