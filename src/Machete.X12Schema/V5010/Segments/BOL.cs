namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BOL :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> ShipmentMethodOfPayment1 { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> StatusReportRequestCode { get; }
        
        Value<string> SectionSevenCode { get; }
        
        Value<string> CustomsDocumentationHandlingCode { get; }
        
        Value<string> ShipmentMethodOfPayment2 { get; }
        
        Value<string> CurrencyCode { get; }
    }
}