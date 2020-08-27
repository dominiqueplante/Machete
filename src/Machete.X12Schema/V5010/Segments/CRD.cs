namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CRD :
        X12Segment
    {
        Value<string> CountryCode { get; }
        
        Value<string> AmountQualifierCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<int> PercentIntegerFormat { get; }
    }
}