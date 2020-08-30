namespace Machete.X12Schema.V5010
{
    using X12;


    public interface B3A :
        X12Segment
    {
        Value<string> TransactionTypeCode { get; }
        
        Value<int> NumberOfShipments { get; }
    }
}