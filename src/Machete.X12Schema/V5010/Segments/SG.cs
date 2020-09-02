namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface SG :
        X12Segment
    {
        Value<string> ShipmentStatusCode { get; }
        
        Value<string> StatusReasonCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<TimeSpan> Time { get; }

        Value<string> TimeCode { get; }
    }
}