namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface R3 :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> RoutingSequenceCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> InvoiceNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> Amount { get; }
        
        Value<string> FreeformDescription { get; }
        
        Value<string> ServiceLevelCode1 { get; }
        
        Value<string> ServiceLevelCode2 { get; }
        
        Value<string> ServiceLevelCode3 { get; }
    }
}