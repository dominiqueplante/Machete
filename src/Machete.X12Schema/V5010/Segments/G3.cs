namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G3 :
        X12Segment
    {
        Value<decimal> CompensationPaid { get; }
        
        Value<int> TotalCompensationAmount { get; }
        
        Value<string> Name { get; }
        
        Value<string> BusinessTransactionStatus { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> CompensationQualifier { get; }
    }
}