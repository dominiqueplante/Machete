namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface AT7 :
        X12Segment
    {
        Value<string> ShipmentStatusIndicator { get; }
        
        Value<string> ShipmentStatusOrAppointmentReasonCode1 { get; }
        
        Value<string> ShipmentAppointmentStatusCode { get; }
        
        Value<string> ShipmentStatusOrAppointmentReasonCode2 { get; }
        
        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }

        Value<string> TimeCode { get; }
    }
}