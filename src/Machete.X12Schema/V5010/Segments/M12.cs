namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M12 :
        X12Segment
    {
        Value<string> CustomsEntryTypeCode { get; }
        
        Value<string> CustomsEntryNumber { get; }
        
        Value<string> LocationIdentifier1 { get; }
        
        Value<string> LocationIdentifier2 { get; }
        
        Value<string> CustomsShipmentValue { get; }
        
        Value<string> InbondControlNumber { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> ReferenceIdentifierQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> VesselName { get; }
    }
}