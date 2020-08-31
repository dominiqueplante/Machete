namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ACS :
        X12Segment
    {
        Value<decimal> Amount { get; }

        Value<string> SpecialChargeOrAllowanceCode { get; }
        
        Value<string> Description { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
    }
}