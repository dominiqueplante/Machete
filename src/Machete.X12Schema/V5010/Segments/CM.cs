namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface CM :
        X12Segment
    {
        Value<string> FlightOrVoyageNumber { get; }
        
        Value<string> PortOrTerminalFunctionCode { get; }
        
        Value<string> PortName { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<string> BookingNumber { get; }
        
        Value<string> StandardCarrierAlphaCode1 { get; }
        
        Value<string> StandardCarrierAlphaCode2 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> VesselName { get; }
        
        Value<string> PierNumber { get; }
        
        Value<string> PierName { get; }
        
        Value<string> TerminalName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> CorrectionIndicator { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
    }
}