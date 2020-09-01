namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface Y3 :
        X12Segment
    {
        Value<string> BookingNumber { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> PierName { get; }
        
        Value<DateTime> Date3 { get; }

        Value<TimeSpan> Time { get; }
        
        Value<string> TransportationMethodCode { get; }
        
        Value<string> TariffServiceCode { get; }

        Value<string> TimeCode { get; }
    }
}