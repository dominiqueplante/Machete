namespace Machete.X12Schema.V5010
{
    using X12;


    public interface H6 :
        X12Segment
    {
        Value<string> SpecialServicesCode1 { get; }
        
        Value<string> SpecialServicesCode2 { get; }
        
        Value<string> QuantityOfPalletsShipped { get; }
        
        Value<string> PalletExchangeCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> PickupOrDeliveryCode { get; }
    }
}