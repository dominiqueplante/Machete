namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C4 :
        X12Segment
    {
        Value<string> CurrencyCode { get; }
        
        Value<decimal> NetAmountDue { get; }
    }
}