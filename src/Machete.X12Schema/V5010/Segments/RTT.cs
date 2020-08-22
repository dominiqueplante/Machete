namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RTT :
        X12Segment
    {
        Value<string> RateOrValueQualifier { get; }
        
        Value<decimal> FreightRate { get; }
    }
}