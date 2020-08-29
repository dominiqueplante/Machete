namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G85 :
        X12Segment
    {
        Value<string> IntegrityCheckValue { get; }
    }
}