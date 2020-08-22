namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CD3 :
        X12Segment
    {
        Value<string> WeightQualifier { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> Zone { get; }
        
        Value<decimal> ServiceStandard { get; }
        
        Value<string> ServiceLevelCode1 { get; }
        
        Value<string> PickupDeliveryCode { get; }
        
        Value<string> RateOrValueQualifier1 { get; }
        
        Value<decimal> AmountCharged1 { get; }
        
        Value<string> RateOrValueQualifier2 { get; }
        
        Value<decimal> AmountCharged2 { get; }
        
        Value<string> ServiceLevelCode2 { get; }
        
        Value<string> ServiceLevelCode3 { get; }
        
        Value<string> PaymentMethodCode { get; }
        
        Value<string> CountryCode { get; }
    }
}