namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L8 :
        X12Segment
    {
        Value<decimal> BilledOrRatedAsQuantity { get; }
        
        Value<string> BilledOrRatedAsQualifier { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> FreightRate { get; }
        
        Value<string> RateOrValueQualifier { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> SpecialChargeOrAllowanceCode { get; }
        
        Value<string> SpecialChargeDescription { get; }
        
        Value<string> ChargeMethodOfPayment { get; }
    }
}