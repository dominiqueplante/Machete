namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SMD :
        X12Segment
    {
        Value<string> ServiceLevelCode { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> PickupOrDeliveryCode { get; }
    }
}