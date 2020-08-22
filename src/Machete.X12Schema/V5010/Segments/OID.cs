namespace Machete.X12Schema.V5010
{
    using X12;


    public interface OID :
        X12Segment
    {
        Value<string> ReferenceIdentification1 { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> PackagingFormCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> ApplicationErrorConditionCode { get; }
        
        Value<string> ReferenceIdentification3 { get; }
    }
}