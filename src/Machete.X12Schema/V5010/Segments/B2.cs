namespace Machete.X12Schema.V5010
{
    using X12;


    public interface B2 :
        X12Segment
    {
        Value<string> TariffServiceCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> ShipmentQualifier { get; }
        
        Value<int> TotalEquipment { get; }
        
        Value<string> ShipmentWeightCode { get; }
        
        Value<string> CustomsDocumentationHandlingCode { get; }
        
        Value<string> TransportationTermsCode { get; }
        
        Value<string> PaymentMethodCode { get; }
    }
}