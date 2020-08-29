namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G89 :
        X12Segment
    {
        Value<string> DirectStoreDeliverySequenceNumber { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<string> UPCOrEANConsumerPackageCode { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> UPCCaseCode { get; }
        
        Value<string> ItemListCost { get; }
        
        Value<decimal> Pack { get; }
        
        Value<int> InnerPack { get; }
    }
}