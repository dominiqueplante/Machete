namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C3 :
        X12Segment
    {
        Value<string> CurrencyCode1 { get; }
        
        Value<decimal> ExchangeRate { get; }
        
        Value<string> CurrencyCode2 { get; }
        
        Value<string> CurrencyCode3 { get; }
    }
}