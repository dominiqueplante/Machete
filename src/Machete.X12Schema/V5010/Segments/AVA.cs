namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AVA :
        X12Segment
    {
        Value<decimal> MonetaryAmount { get; }
        
        Value<decimal> Availability { get; }
    }
}