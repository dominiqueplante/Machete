namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface B3B :
        X12Segment
    {
        Value<string> InvoiceNumber { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<decimal> NetAmountDue { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> CorrectionIndicator { get; }
        
        Value<string> CurrencyCode { get; }
    }
}