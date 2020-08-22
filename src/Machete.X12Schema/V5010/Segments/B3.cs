namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface B3 :
        X12Segment
    {
        Value<string> ShipmentQualifier { get; }
        
        Value<string> InvoiceNumber { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<decimal> NetAmountDue { get; }
        
        Value<decimal> CorrectionIndicator { get; }
        
        Value<DateTime> DeliveryDate { get; }
        
        Value<string> DateOrTimeQualifier { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> TariffServiceCode { get; }
        
        Value<string> TransportationTermsCode { get; }
    }
}