namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G87 :
        X12Segment
    {
        Value<string> InitiatorCode { get; }
        
        Value<string> CreditOrDebitFlagCode { get; }
        
        Value<string> SupplierDeliveryOrReturnNumber { get; }
        
        Value<string> IntegrityCheckValue { get; }
        
        Value<int> AdjustmentSequenceNumber { get; }
        
        Value<string> ReceiverDeliveryOrReturnNumber { get; }
    }
}