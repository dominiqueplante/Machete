namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L9 :
        X12Segment
    {
        Value<string> SpecialChargeOrAllowanceCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
    }
}