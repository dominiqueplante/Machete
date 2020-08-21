namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface POD :
        X12Segment
    {
        Value<DateTime> Date { get; }
        Value<TimeSpan> Time { get; }
        Value<string> Name { get; }
    }
}