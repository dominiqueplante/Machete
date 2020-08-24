namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT3 :
        X12Segment
    {
        Value<decimal> AmountCharge { get; }
        
        Value<string> FreightRateQualifier { get; }
        
        Value<decimal> FreightRate { get; }
        
        Value<string> RateAsQualifier { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> BillOfLadingChargeCode { get; }
        
        Value<string> PercentageAsDecimal { get; }
    }
}