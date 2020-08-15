namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface M3 :
        X12Segment
    {
        Value<string> ReleaseCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> TimeCode { get; }
    }
}