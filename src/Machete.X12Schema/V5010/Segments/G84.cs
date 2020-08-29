namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G84 :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<decimal> TotalInvoiceAmount { get; }
        
        Value<decimal> TotalDepositDollarAmount { get; }
    }
}